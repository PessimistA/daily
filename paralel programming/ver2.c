#include <stddef.h> // offsetof makrosu için gerekli
#include <mpi.h>
#include <stdio.h>
struct Particle
{
    int id;
    double coordinates[3];
};
int main(int argc, char** argv) {
    MPI_Init(&argc, &argv);

    int rank;
    MPI_Comm_rank(MPI_COMM_WORLD, &rank);

    // Sadece Rank 0 ekrana yazdırsın ki ortalık karışmasın
    if (rank == 0) {
        printf("--- STANDART VERI TIPLERI ---\n");
        int int_size, double_size;
        MPI_Type_size(MPI_INT, &int_size);
        MPI_Type_size(MPI_DOUBLE, &double_size);
        printf("Sistemde MPI_INT boyutu: %d byte\n", int_size);
        printf("Sistemde MPI_DOUBLE boyutu: %d byte\n\n", double_size);

        printf("--- CUSTOM (OZEL) VERI TIPI OLUSTURMA ---\n");
    }

    // MPI'a kendi struct'ımızı öğretmek için gereken harita malzemeleri
    MPI_Datatype MPI_PARTICLE; // Yeni veri tipimizin adı
    int blocklengths[2] = {1, 3}; // 1 tane int, 3 tane double var
    MPI_Datatype types[2] = {MPI_INT, MPI_DOUBLE}; // Tiplerin sırası
    MPI_Aint offsets[2]; // Bellekteki konumları (offset)

    // Struct içindeki değişkenlerin bellek başlangıç noktalarını buluyoruz
    offsets[0] = offsetof(struct Particle, id);
    offsets[1] = offsetof(struct Particle, coordinates);

    // 1. Yeni veri tipini yarat
    MPI_Type_create_struct(2, blocklengths, offsets, types, &MPI_PARTICLE);
    
    // 2. Sistemi bu yeni tipe hazırla (Commit)
    MPI_Type_commit(&MPI_PARTICLE);

    if (rank == 0) {
        int custom_size;
        MPI_Type_size(MPI_PARTICLE, &custom_size);
        printf("Basariyla yeni bir tip yaratildi!\n");
        printf("Custom MPI_PARTICLE boyutu: %d byte\n", custom_size);
    }

    // İşimiz bitince belleği temizle (İyi bir programlama pratiği)
    MPI_Type_free(&MPI_PARTICLE);

    MPI_Finalize();
    return 0;
}

