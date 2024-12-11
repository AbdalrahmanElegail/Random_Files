#include <iostream>
using namespace std;


int main()
{
    int t;  cin >>t;

    for (int j=0; j<t ; j++)
        {
            int n;  cin>>n;
            int arr[n],prer[n+1],prel[n+1];prel[0]=0;prer[0]=0;
            for(int i=0 ; i<n ; i++){cin>>arr[i];}
            for(int i=0 ; i<n ; i++){prel[i+1]=prel[i]+arr[i];  prer[i+1]=prer[i]+arr[n-i-1];}

            for(int l=n-1 ; l>1 ; l--)
            {
                for(int k=n-l ; k>1 ; k--)
                {
                    if (prel[l]==prer[k]){cout<<"----------------"<<l+k-2<<endl;}
                }
            }


            for(int i=0 ; i<=n ; i++){cout<<prel[i]<<" ";}
            cout<<endl;
            for(int i=0 ; i<=n ; i++){cout<<prer[i]<<" ";}
            cout<<endl;


        }





    return 0;
}
