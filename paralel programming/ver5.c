#include <mpi.h>
#include <stdio.h>


void ping_f(int rank,int* token,int size){
    int right_neighbor= (rank+1)%size;
    int left_neighbor= (rank-1+size)%size; 
    //MPI_Send(const void *buf, int count, MPI_Datatype datatype, int dest, int tag, MPI_Comm comm)
    MPI_Send((token),1,MPI_INT,right_neighbor,0,MPI_COMM_WORLD);//MPI_COMM_WORLD genel sohbet kanalıdır
    MPI_Status status;
    MPI_Recv((token),1,MPI_INT,left_neighbor,0,MPI_COMM_WORLD,&status);//pointer ve & gelince bir şey yazmana gerek yok
    printf("[rank:%d] işlem tamamlandı. Geri dönen sonuç %d\n",rank,(*token));
}

void pong_f(int rank,int* token, int size){

    int right_neighbor= (rank+1)%size;
    int left_neighbor= (rank-1+size)%size;
    MPI_Status status;
    //MPI_Recv(void *buf, int count, MPI_Datatype datatype, int source, int tag, MPI_Comm comm, MPI_Status *status)
    MPI_Recv((token),1,MPI_INT,left_neighbor,0,MPI_COMM_WORLD,&status);//tag=0 demek data mesajları demektir
    
    (*token) +=10;
    MPI_Send((token),1,MPI_INT,right_neighbor,0,MPI_COMM_WORLD);
}

int main(int argc, char** argv) {
    int rank,size;

    MPI_Init(&argc,&argv);
    MPI_Comm_rank(MPI_COMM_WORLD,&rank);
    MPI_Comm_size(MPI_COMM_WORLD,&size);

    
    if (size<2)
    {
        if(rank==0){
            printf("hata en az 2 işlemci gerekmektedir");
        }
        MPI_Finalize();
        return 0;
    }

    int token=100;
    if (rank==0)
    {
        ping_f(rank,&token,size);
    }
    else 
    {
        pong_f(rank,&token,size);
    }

    MPI_Finalize();
    return 0;
}

