"""                                   this is contest                                     """
# prob 1
# print("Kareem Elgoker now has no authority, Adham is the new head and Samer is his vice.")


# prob d

# n, k = list(map(int, input().split()))
# s = f"{input()}"
# ss = list(s)

# for i in range(k):
#     ss.pop(s.find(max(s)))


# for i in range(n-k):
#     print(ss[i], end="")


# prob g

s = input()
m = int(input())
presum = [0]


for j in range(1, len(s)):
    if (s[j] == s[j - 1]):
        presum.append(1)
    else:
        presum.append(0)
    presum[j] += presum[j - 1]


for i in range(m):

    l, r = list(map(int, input().split()))

    print(presum[r - 1] - presum[l - 1])
