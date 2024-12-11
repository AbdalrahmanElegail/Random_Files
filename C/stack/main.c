#include <stdio.h>
#include<stdbool.h>
#define MAX_SIZE 100


char stack[MAX_SIZE];
int top = -1;

bool isEmpty()
{
    return top == -1;
}

bool isFull()
{
    return top == MAX_SIZE - 1;
}

void push(char item)
{
    if (isFull())
    {
        printf("Stack Overflow\n");
        return;
    }
    stack[++top] = item;
}

char pop()
{
    if (isEmpty())
    {
        printf("Stack Underflow\n");
        return;
    }
    return stack[top--];
}

char peek()
{
    if (isEmpty())
    {
        printf("Stack is empty\n");
        return -1;
    }
    return stack[top];
}

void display()
{
    if (isEmpty())
    {
        printf("Stack is empty\n");
        return;
    }
    printf("Stack elements: ");
    for (int i = top; i >= 0; i--)
    {
        printf("%c ", stack[i]);
    }
    printf("\n");
}

int main()
{
    int count1=0;
    int count2=0;
    int count3=0;
    int count11=0;
    int count22=0;
    int count33=0;

0    char string[50];    scanf("%s",string);
    for (int i=0 ; i<50 ; i++)
    {
        if (string[i]=='['){count1++;}
        else if (string[i]=='{'){count2++;}
        else if (string[i]=='('){count3++;}
        else if (string[i]==']'){count11++;}
        else if (string[i]=='}'){count22++;}
        else if (string[i]==')'){count33++;}
    }

    if (string [0]== ']' || string [0]== ')' || string [0]== '}' || string [50]== '[' || string [50]== '(' || string [50]== '{' )
    {
        printf("not balanced");
    }
    else if (count1==count11&&count2==count22&&count3==count33){printf("balanced");}
    else  printf("not balanced");



    return 0;
}
