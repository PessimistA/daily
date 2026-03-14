#include <mpi.h>
#include <stdio.h>

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
    }
    if (rank==0)
    {
        int data_to_send= 1453;//bufferda gönderilen boyut kadar karşı taraf almalı 
        MPI_Status status;
        //MPI_Send(const void *buf, int count, MPI_Datatype datatype, int dest, int tag, MPI_Comm comm)
        MPI_Send(&data_to_send,1,MPI_INT,1,0,MPI_COMM_WORLD);//MPI_COMM_WORLD genel sohbet kanalıdır
        printf("veri gönderildi:%d\n",data_to_send);

    }
    if (rank==1)
    {
        int data_to_recv;
        MPI_Status status;
        //MPI_Recv(void *buf, int count, MPI_Datatype datatype, int source, int tag, MPI_Comm comm, MPI_Status *status)
        MPI_Recv(&data_to_recv,1,MPI_INT,0,0,MPI_COMM_WORLD,&status);//tag=0 demek data mesajları demektir
        printf("veri gönderildi:%d\n",data_to_recv);
        printf("status bilgisi: %d \n Mesaj etiketi: %d \n Veri alındı: %d\n",status.MPI_SOURCE,status.MPI_TAG,data_to_recv);
        
    }
    //deadlock oluşması için ikisininde en üst satırında mesala recv olması gerekir ikisi de bekler ama gelen olmaz

    MPI_Finalize();
    return 0;
}