#include <iostream>
#include <vector>
#include <algorithm>
#define all(v) ((v).begin()),((v).end())
#define sz(v)  ((int)((v).size()))
using namespace std;
typedef vector<long long> vi;

int main()
{
    int n;    cin>>n;
    double t;    cin>>t;
    long long pro=1;
    vi a(n);
    double sum=0;
    for(int i=0 ; i<n ; i++)
    {
        cin>>a[i];
        sum+=(1.0/a[i]);
        pro*=a[i];
    }
    sort(all(a));
    long long preresult= (long long)((t/a[0])/(sum))+1;
    cout<<(10*n*preresult)/(pro/a[0]);
    return 0;
}
