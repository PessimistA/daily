#include <mpi.h>
#include <stdio.h>
int main(int argc,char** argv){
    int rank,size;

    MPI_Init(&argc,&argv);
    MPI_Comm_rank(MPI_COMM_WORLD,&rank);
    MPI_Comm_size(MPI_COMM_WORLD,&size);

    if( rank==0){
        printf("-- master-rank %d ve toplam %d  işlemci sisteme katıldı --\n",rank,size);
    }
    else{
        printf("-- worker-rank %d --\n",rank);
    }
    MPI_Finalize();
    return 0;

}

