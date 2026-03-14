
#include <mpi.h>
#include <stdio.h>

int main(int argc, char** argv) {
    int rank, size;
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    if (size != 2) {
        if (rank == 0) printf("Hata: Sadece 2 islemci ile test edin.\n");
        MPI_Finalize();
        return 1;
    }

    int sayac = 0; 
    int max_tur = 5;
    
    // Arka plan işlemlerini takip edecek nesneler
    MPI_Request req_send, req_recv; 

    // --- RANK 0 ---
    if (rank == 0) {
        for (int i = 0; i < max_tur; i++) {
            sayac += 10;
            
            // 1. Beklemeden gönderimi başlat
            MPI_Isend(&sayac, 1, MPI_INT, 1, 0, MPI_COMM_WORLD, &req_send);
            // DİKKAT: Gönderim bitmeden bir alt satırdaki alıma geçersek aynı değişkeni (sayac) bozabiliriz.
            // Bu yüzden gönderimin arka planda bitmesini beklemek zorundayız.
            //MPI_Wait(&req_send, MPI_STATUS_IGNORE); 
            
            // 2. Beklemeden alımı başlat
            MPI_Irecv(&sayac, 1, MPI_INT, 1, 0, MPI_COMM_WORLD, &req_recv);
            // DİKKAT: Veri tam olarak gelmeden döngü başa dönerse ve biz üzerine 10 eklemeye kalkarsak
            // çöp bir değeri toplamış oluruz. Mecburen kargonun gelmesini bekliyoruz.
            MPI_Wait(&req_recv, MPI_STATUS_IGNORE); 
            
            printf("[Rank 0] Tur %d tamamlandi. Guncel sayac: %d\n", i+1, sayac);
        }
        printf("--- FINAL SONUC --- Rank 0'in elindeki son sayi: %d\n", sayac);
    } 
    // --- RANK 1 ---
    else if (rank == 1) {
        for (int i = 0; i < max_tur; i++) {
            // 1. Beklemeden alımı başlat
            MPI_Irecv(&sayac, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, &req_recv);
            // Rank 0'ın gönderdiği güncel sayac gelmeden üzerine 10 ekleyemeyiz! Bekle!
            //MPI_Wait(&req_recv, MPI_STATUS_IGNORE); 
            
            sayac += 10;
            
            // 2. Beklemeden gönderimi başlat
            MPI_Isend(&sayac, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, &req_send);
            // Döngü başa dönüp yeni bir alım başlatmadan önce bu paketin yola çıktığından emin ol!
            MPI_Wait(&req_send, MPI_STATUS_IGNORE); 
            
            printf("  -> [Rank 1] Tur %d tamamlandi. Guncel sayac: %d\n", i+1, sayac);
        }
        printf("--- FINAL SONUC --- Rank 1'in elindeki son sayi: %d\n", sayac);
    }
    //Bu kodda waitleri kapatırsan ikisinin her rank sonucu aynı çıkar ama en son 50 olur-> birbiriyleriyle hiç haberleşmediler ikisi de sadece işlemi yapıp bitirdi
    // kapatmazsan en son 100 olur 
    MPI_Finalize();
    return 0;
}