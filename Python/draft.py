# """     div 4 contist    """


# """ prob num 1.1 """
# t = int(input())
# for i in range(t):
#     num = int(input())
#     print(int(num/10)+int(num % 10))


# """ prob num 1.2 """
# t = int(input())
# for i in range(t):
#     a1, a2, b1, b2 = list(map(int, input().split()))
#     c = int(0)
#     if ((a1 >= b1) & (a2 > b2)) | ((a1 > b1) & (a2 >= b2)):
#         c = c+1
#     if ((a1 >= b2) & (a2 > b1)) | ((a1 > b2) & (a2 >= b1)):
#         c = c+1
#     print(2*c)


# """ prob num 1.3 """               uncompleted
# t = int(input())
# for i in range(t):
#     c, first = 0, 0
#     n, s, m = list(map(int, input().split()))
#     x = []
#     for j in range(n):
#         x.append(list(map(int, input().split())))
#     if (x[0] >= s) | ((m-x[n-1]) >= s):
#         c = c+1
#     for j in range(n/2):
#         if (x[2*j+2]-x[2*j+1]) > s:
#             c = c+1
#     if c == 0:
#         print("NO")
#     else:
#         print("YES")


#      DIV 3


# """ prob num 2.1 """


# t = int(input())
# for i in range(t):
#     x = int(input())
#     if (x >= 102 and x <= 109) or (x >= 1010 and x <= 1099):
#         print("YES")
#     else:
#         print("NO")


# """ prob num 2.2 """

# t = int(input())
# for _ in range(t):
#     x = int(input())
#     a = list(map(int, input().split()))
#     b = [a[0]]
#     for i in range(1, x):
#         if (a[i] - 1 in b) or (a[i] + 1 in b):
#             b.append(a[i])
#         else:
#             print("NO")
#             break
#     else:
#         print("YES")
