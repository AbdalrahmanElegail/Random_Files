#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <string.h>
#define QUEUE_SIZE 1000

int nElement = 0;
int rear = -1;
int front = 0;
char *queue[QUEUE_SIZE];

void initializeQueue()
{
    rear = -1;
    front = 0;
    nElement = 0;
}

void enqueue(char *n)
{
    if (rear == QUEUE_SIZE - 1)
    {
        printf("Queue is full.\n");
        return;
    }

    queue[++rear] = strdup(n);
    nElement++;

    if (front == -1){   front = 0;  }
}

char *dequeue()
{
    if (nElement == 0)
    {
        printf("Queue is empty.\n");
        return NULL;
    }

    nElement--;
    return queue[front++];
}


int main()
{
    int number;
    printf("print binary numbers from 0 to: ");
    scanf("%d", &number);

    enqueue("1");

    if (number==0){printf("0\n");}
    else
    {
        printf("0\n");
        while (number > 0)
        {
            char *binary_number = dequeue();

            char num1[QUEUE_SIZE], num2[QUEUE_SIZE];
            sprintf(num1, "%s0", binary_number);
            sprintf(num2, "%s1", binary_number);

            enqueue(num1);
            enqueue(num2);

            printf("%s\n", binary_number);

            number--;
        }
    }
    return 0;
}
