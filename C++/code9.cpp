#include<iostream>
using namespace std;
int main(){
    int i,j,n,arr[50];
    cout<<"Enter the no of elements"<<endl;
    cin>>n;
    cout<<"Enter the nos"<<endl;
    for(i=0;i<n;i++){
        cin>>arr[i];
    }

    for(i=0;i<n-1;i++){
        int minindex=i;
        for(j=i+1;j<n;j++){
            if(arr[j]<arr[minindex]){
                minindex=j;
            }
        }
        if(minindex!=i){
            int temp=arr[i];
            arr[i]=arr[minindex];
            arr[minindex]=temp;
        }
    }

    for(i=0;i<n;i++){
        cout<<arr[i]<<endl;
    }
}