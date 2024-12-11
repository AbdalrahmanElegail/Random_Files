#include <stdio.h>
#include <stdbool.h>

#define STACK_SIZE 100

char stack[STACK_SIZE];
int top = -1;

void push(char value)
{
    if (top >= STACK_SIZE - 1)
    {
        printf("Stack Overflow\n");
        return;
    }
    stack[++top] = value;
}

char pop()
{
    if (top < 0)
    {
        printf("Stack Underflow\n");
        return '\0';
    }
    return stack[top--];
}

bool isNotEmpty()
{
    return top >= 0;
}

bool hasHighPriority(char top, char operator)
{
    char precedence[] = {'+', '-', '*', '/'};

    int i;
    int topIndex = -1;
    int operatorIndex = -1;

    for (i = 0; i < 4; i++)
    {
        if (precedence[i] == top)
        {
            topIndex = i;
        }
        if (precedence[i] == operator)
        {
            operatorIndex = i;
        }
    }

    if (topIndex != -1 && operatorIndex != -1)
    {
        return topIndex >= operatorIndex;
    }

    return false;
}

int main()
{
    char exp[100];
    printf("Enter your infix expression: ");
    scanf("%s", exp);

    char op[] = {'+', '-', '/', '*'};
    char pt[] = {'(', ')'};

    char new_exp[100] = "";
    int p = 0;
    int i = 0;

    while (exp[i] != '\0')
    {
        if (!(exp[i] == op[0] || exp[i] == op[1] || exp[i] == op[2] || exp[i] == op[3] ||
              exp[i] == pt[0] || exp[i] == pt[1])) // is num
        {
            new_exp[p++] = exp[i];
        }
        else if (exp[i] == op[0] || exp[i] == op[1] || exp[i] == op[2] || exp[i] == op[3]) // is op
        {
            while (isNotEmpty() && hasHighPriority(stack[top], exp[i]) && stack[top] != pt[0])
            {
                new_exp[p++] = pop();
            }
            push(exp[i]);
        }
        else if (exp[i] == pt[0]) // is (
        {
            push(exp[i]);
        }
        else if (exp[i] == pt[1]) // is )
        {
            while (isNotEmpty() && stack[top] != pt[0])
            {
                new_exp[p++] = pop();
            }
            if (stack[top] == pt[0])
            {
                pop(); // to delete the ( we pushed
            }
        }
        i++;
    }

    while (isNotEmpty()) // if there any op with less priority left
    {
        new_exp[p++] = pop();
    }

    new_exp[p] = '\0';

    printf("%s\n", new_exp);
    // 2+3*(2-4)/8
    // ((a+b)*c-d)*e
    // 2+4/5*(5-3)

    return 0;
}
