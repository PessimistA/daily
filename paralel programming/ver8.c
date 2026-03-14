
//Burası senkron altta da asenkron kod var kıyaslama yazımı
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

    int sayac = 0; // Rank 0'ın da Rank 1'in de KENDİNE AİT bir sayac değişkeni oluştu.
    int max_tur = 5;

    // --- RANK 0 ---
    if (rank == 0) {
        for (int i = 0; i < max_tur; i++) {
            // Kendi sayacına 10 ekle ve gönder
            sayac += 10;
            MPI_Send(&sayac, 1, MPI_INT, 1, 0, MPI_COMM_WORLD);//tam tersi sıra burada da kullanılmalı
            
            // Karşı tarafın ekleme yapıp geri gönderdiği yeni sayacı bekle
            MPI_Recv(&sayac, 1, MPI_INT, 1, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);
            
            printf("[Rank 0] Tur %d tamamlandi. Guncel sayac: %d\n", i+1, sayac);
        }
        printf("--- FINAL SONUC --- Rank 0'in elindeki son sayi: %d\n", sayac);
    } 
    // --- RANK 1 ---
    else if (rank == 1) {
        for (int i = 0; i < max_tur; i++) {
            // Önce Rank 0'dan gelen güncel sayacı bekle
            MPI_Recv(&sayac, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, MPI_STATUS_IGNORE);// üzerine yazma nedenimiz kimden geldiğiniz umursamıyoruz sadece veriyi umursuyoruz
            
            // Gelen sayacın üzerine 10 ekle ve geri yolla
            sayac += 10;
            MPI_Send(&sayac, 1, MPI_INT, 0, 0, MPI_COMM_WORLD);
            
            printf("  -> [Rank 1] Tur %d tamamlandi. Guncel sayac: %d\n", i+1, sayac);//gelen 10 üzerine 10 ekledikten sonra 1. tur bitti yani 20 şerlli artıyor
        }
        printf("--- FINAL SONUC --- Rank 1'in elindeki son sayi: %d\n", sayac);
    }

    MPI_Finalize();
    return 0;
}