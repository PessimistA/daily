#include <mpi.h>
#include <stdio.h>

#include <unistd.h> // sleep() fonksiyonu için

int main(int argc, char** argv) {
    int rank, size;
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    if (size != 2) {
        if (rank == 0) printf("Lutfen tam 2 islemci ile calistirin.\n");
        MPI_Finalize();
        return 1;
    }

    int data_to_send = (rank == 0) ? 999 : 888; // Rank 0 999 göndersin, Rank 1 888 göndersin
    int data_to_recv = 0;
    
    int target = (rank == 0) ? 1 : 0; // Hedef rank (0 ise 1'e, 1 ise 0'a)

    // Arka plan işlemlerini takip etmek için Request nesneleri
    MPI_Request request_send, request_recv;

    // 1. İletişimi Başlat (BEKLEMEDEN ALT SATIRA GEÇER)
    // Parametrelerin sonuna &request_send ve &request_recv eklendiğine dikkat et
    //MPI_Isend(const void *buf, int count, MPI_Datatype datatype, int dest, int tag, MPI_Comm comm, MPI_Request *request)
    MPI_Isend(&data_to_send, 1, MPI_INT, target, 0, MPI_COMM_WORLD, &request_send);
    //MPI_Irecv(void *buf, int count, MPI_Datatype datatype, int source, int tag, MPI_Comm comm, MPI_Request *request)
    MPI_Irecv(&data_to_recv, 1, MPI_INT, target, 0, MPI_COMM_WORLD, &request_recv);

    // 2. İletişim Arka Planda Sürerken Başka İşler Yap (HESAPLAMA)
    // İşlemci burada ağın yavaşlığını beklemiyor, kendi işine bakıyor.
    printf("[Rank %d] Kargo yola cikti. Ben o sirada matematik yapiyorum...\n", rank);
    sleep(1); // Temsili ağır bir matematiksel işlem (1 saniye uyut)
    printf("[Rank %d] Matematik isim bitti. Simdi kargolara bakalim.\n", rank);

    // 3. Veriyi Kullanmadan Önce İşlemlerin Bittiğinden Emin Ol
    MPI_Status status;
    MPI_Wait(&request_send, MPI_STATUS_IGNORE); // Gönderim bitti mi?
    MPI_Wait(&request_recv, &status);           // Alım bitti mi?

    // Artık data_to_recv değişkenini güvenle kullanabiliriz
    printf("[Rank %d] Gelen veri basariyla okundu: %d\n", rank, data_to_recv);

    MPI_Finalize();
    return 0;
}

