#include <mpi.h>
#include <stdio.h>

int main(int argc, char** argv) {
    int rank, size;
    
    MPI_Init(&argc, &argv);
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);
    MPI_Comm_size(MPI_COMM_WORLD, &size);

    // Bu senaryoyu tam kapasite görmek için 4 işlemci şart koşuyoruz
    if (size != 4) {
        if (rank == 0) printf("Hata: Bu kodu tam olarak 4 islemci ile (mpirun -np 4) calistirin.\n");
        MPI_Finalize();
        return 1;
    }

    // 1. MPI_BARRIER (Senkronizasyon)
    // Herkes buraya gelene kadar kimse alt satira gecemez. Yaris cizgisi.
    MPI_Barrier(MPI_COMM_WORLD);
    if (rank == 0) printf("--- Tum islemciler hazir, operasyon basliyor! ---\n\n");

    // 2. MPI_BCAST (Yayın / Ortak Bilgi Dagilimi)
    int carpan;
    if (rank == 0) {
        carpan = 5; // Bu veriyi sadece Rank 0 biliyor
    }
    // Rank 0 elindeki 'carpan' degerini diger tum islemcilere kopyalar.
    // DİKKAT: if(rank==0) bloğunun dışında! Herkes bu satırı çalıştırır.
    //MPI_Bcast(void *buffer, int count, MPI_Datatype datatype, int root, MPI_Comm comm)
    MPI_Bcast(&carpan, 1, MPI_INT, 0, MPI_COMM_WORLD); 


    // 3. MPI_SCATTER (Diziyi Parçalayıp Dağıtma)
    int ana_dizi[4];
    int gelen_parca; // Her islemciye 1 adet veri dusecek

    if (rank == 0) {
        // Rank 0 elindeki büyük veriyi hazırlar
        ana_dizi[0] = 10;
        ana_dizi[1] = 20;
        ana_dizi[2] = 30;
        ana_dizi[3] = 40;
    }
    // Rank 0, ana_dizi'yi 1'er 1'er koparıp herkese (kendisi dahil) dagitir.
    //MPI_Scatter(const void *sendbuf, int sendcount, MPI_Datatype sendtype, void *recvbuf, int recvcount, MPI_Datatype recvtype, int root, MPI_Comm comm)
    MPI_Scatter(ana_dizi, 1, MPI_INT, &gelen_parca, 1, MPI_INT, 0, MPI_COMM_WORLD);

    // --- HESAPLAMA FAZI ---
    // Her islemci kendi parcasini, Bcast ile gelen ortak carpan ile carpiyor
    int islenmis_veri = gelen_parca * carpan;
    printf("[Rank %d] Aldigim parca: %d | Carpan: %d | Sonuc: %d\n", rank, gelen_parca, carpan, islenmis_veri);


    // 4. MPI_GATHER (Sonucları Geri Toplama)
    int toplanan_dizi[4]; // Sonuclar Rank 0'da bu dizide birlesecek

    // Herkes elindeki islenmis_veri'yi Rank 0'a gönderir, Rank 0 bunlari dizide uca uca ekler.
    //MPI_Gather(const void *sendbuf, int sendcount, MPI_Datatype sendtype, void *recvbuf, int recvcount, MPI_Datatype recvtype, int root, MPI_Comm comm)
    MPI_Gather(&islenmis_veri, 1, MPI_INT, toplanan_dizi, 1, MPI_INT, 0, MPI_COMM_WORLD);

    if (rank == 0) {
        printf("\n[Rank 0] GATHER BASARILI. Toplanan yeni dizi: [%d, %d, %d, %d]\n", 
               toplanan_dizi[0], toplanan_dizi[1], toplanan_dizi[2], toplanan_dizi[3]);
    }


    // 5. MPI_REDUCE (İndirgeme / Matematiksel Birleştirme)
    int genel_toplam = 0; // Tüm sistemdeki sonuclarin toplami

    // Herkes islenmis_veri'sini yollar, MPI bunları arka planda TOPLAR (MPI_SUM) ve genel_toplam'a yazar.
    //MPI_Reduce(const void *sendbuf, void *recvbuf, int count, MPI_Datatype datatype, MPI_Op op, int root, MPI_Comm comm)
    MPI_Reduce(&islenmis_veri, &genel_toplam, 1, MPI_INT, MPI_SUM, 0, MPI_COMM_WORLD);

    if (rank == 0) {
        printf("[Rank 0] REDUCE BASARILI. Tum islenmis verilerin genel toplami: %d\n", genel_toplam);
    }

    MPI_Finalize();
    return 0;
}

/*
[Rank 0] Aldigim parca: 10 | Carpan: 5 | Sonuc: 50

[Rank 0] GATHER BASARILI. Toplanan yeni dizi: [50, 100, 150, 200]
[Rank 0] REDUCE BASARILI. Tum islenmis verilerin genel toplami: 500
[Rank 1] Aldigim parca: 20 | Carpan: 5 | Sonuc: 100
[Rank 2] Aldigim parca: 30 | Carpan: 5 | Sonuc: 150
[Rank 3] Aldigim parca: 40 | Carpan: 5 | Sonuc: 200


*/