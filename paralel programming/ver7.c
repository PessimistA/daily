#include <mpi.h>
#include <stdio.h>

#include <unistd.h> // sleep() fonksiyonu için (Windows kullanıyorsan <windows.h> ve Sleep(1000) gerekir)

int main(int argc, char** argv) {
    int rank, size;
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    if (size != 2) {
        if (rank == 0) printf("Hata: Lutfen tam 2 islemci ile calistirin. (mpirun -np 2)\n");
        MPI_Finalize();
        return 1;
    }

    // --- RANK 0'IN YAPACAĞI İŞLER ---
    if (rank == 0) {
        int data_to_send = 999;
        int data_to_recv;
        MPI_Request req_send, req_recv;

        // 1. Beklemeden gönderimi ve alımı başlat
        //aynı anda çalışır,aynı anda gönderir ve aynı anda alır
        MPI_Isend(&data_to_send, 1, MPI_INT, 1, 0, MPI_COMM_WORLD, &req_send);
        MPI_Irecv(&data_to_recv, 1, MPI_INT, 1, 0, MPI_COMM_WORLD, &req_recv);

        // 2. Arka planda veri giderken kendi işini yap
        printf("[Rank 0] Kargo yola cikti. Baska hesaplamalar yapiyorum...\n");
        sleep(1); // 1 saniyelik temsili matematik işlemi

        // 3. Veriyi kullanmadan önce işlemlerin bittiğinden emin ol
        MPI_Wait(&req_send, MPI_STATUS_IGNORE); // Gönderim bitti mi?
        MPI_Wait(&req_recv, MPI_STATUS_IGNORE); // Alım bitti mi?

        printf("[Rank 0] Gelen veri basariyla okundu: %d\n", data_to_recv);
    }
    
    // --- RANK 1'İN YAPACAĞI İŞLER ---
    else if (rank == 1) {
        int data_to_send = 888;
        int data_to_recv;
        MPI_Request req_send, req_recv;

        // 1. Beklemeden gönderimi ve alımı başlat
        MPI_Isend(&data_to_send, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, &req_send);
        MPI_Irecv(&data_to_recv, 1, MPI_INT, 0, 0, MPI_COMM_WORLD, &req_recv);

        // 2. Arka planda veri giderken kendi işini yap
        printf("[Rank 1] Kargo yola cikti. Baska hesaplamalar yapiyorum...\n");
        sleep(1); // 1 saniyelik temsili matematik işlemi

        // 3. Veriyi kullanmadan önce işlemlerin bittiğinden emin ol
        MPI_Wait(&req_send, MPI_STATUS_IGNORE);
        MPI_Wait(&req_recv, MPI_STATUS_IGNORE);

        printf("[Rank 1] Gelen veri basariyla okundu: %d\n", data_to_recv);
    }
    /*
    [Rank 1] Kargo yola cikti. Baska hesaplamalar yapiyorum...//0 ve 1 lerin yeri değişebilir
    [Rank 0] Kargo yola cikti. Baska hesaplamalar yapiyorum...
    [Rank 0] Gelen veri basariyla okundu: 888
    [Rank 1] Gelen veri basariyla okundu: 999
    */
    
    MPI_Finalize();
    return 0;
}

