#include <stdio.h>
#include<stdbool.h>
#include<string.h>
#include<stdbool.h>
#define SIZE 100

char stack[SIZE];
int top = -1;

bool isEmpty()
{
    return top == -1;
}

bool isFull()
{
    return top == SIZE - 1;
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


void sum()
{
    pop();
    int num1=pop();
    int num2=pop();

    push(num2+num1);
}

void sub()
{
    pop();
    int num1=pop();
    int num2=pop();

    push(num2-num1);
}

void mul()
{
    pop();
    int num1=pop();
    int num2=pop();

    push(num2*num1);
}

bool div()
{
    pop();
    int num1=pop();
    int num2=pop();

    if (num1!=0){push(num2/num1); return true;}
    else {printf("------------- invalid exprission ------------"); return false; }

}



int main()
{

    char exprission[100];
    printf("enter exprission: ");
    scanf("%s",exprission);
    int num1,num2,res;
    if (exprission[0]=='-'|| exprission[0]=='+'|| exprission[0]=='*'|| exprission[0]=='/'||
        exprission[1]=='-'|| exprission[1]=='+'|| exprission[1]=='*'|| exprission[1]=='/')

    {   printf("------------- invalid exprission ------------");    }

    else
    {

        for (int i=0 ; i<strlen(exprission) ; i++)
        {
            push(exprission[i]);

            if      ( peek()=='*')  { mul();    }
            else if ( peek()=='/')  {   if (!div())  break;  }
            else if ( peek()=='+')  {   sum();  }
            else if ( peek()=='-')  {   sub();  }
            else if ( peek()=='(')
            {
                pop();
                bool bracket = true;
                int num_inside=0;
                while (bracket)
                {
                    i++;
                    push(exprission[i]);
                    if (peek()== ')' ) { pop(); bracket=false;}
                    else
                        {
                            num_inside*=10;
                            char temp = pop();
                            num_inside += (int)(temp-'0');
                        }
                }
                push(num_inside);
            }
            else {char num = pop();  push((int)(num-'0'));}
        }
    }
    printf("Result: %d\n", pop());




    return 0;
}
