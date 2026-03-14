#include <mpi.h>
#include <stdio.h>


void ping_f(int rank){
    int data_to_send= 10;//bufferda gönderilen boyut kadar karşı taraf almalı  
    //MPI_Send(const void *buf, int count, MPI_Datatype datatype, int dest, int tag, MPI_Comm comm)
    MPI_Send(&data_to_send,1,MPI_INT,1,0,MPI_COMM_WORLD);//MPI_COMM_WORLD genel sohbet kanalıdır
    int data_to_receive;
    MPI_Status status;
    MPI_Recv(&data_to_receive,1,MPI_INT,1,0,MPI_COMM_WORLD,&status);
    printf("[rank:%d] işlem tamamlandı. Geri dönen sonuç %d\n",rank,data_to_receive);
}

void pong_f(){
    int data_to_recv;
    MPI_Status status;
    //MPI_Recv(void *buf, int count, MPI_Datatype datatype, int source, int tag, MPI_Comm comm, MPI_Status *status)
    MPI_Recv(&data_to_recv,1,MPI_INT,0,0,MPI_COMM_WORLD,&status);//tag=0 demek data mesajları demektir
    
    int data_to_send= data_to_recv*5;
    MPI_Send(&data_to_send,1,MPI_INT,0,0,MPI_COMM_WORLD);
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
    if (rank==0)
    {
        ping_f(rank);
    }
    if (rank==1)
    {
        pong_f();
    }

    MPI_Finalize();
    return 0;
}
