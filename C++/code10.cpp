#include<iostream>
using namespace std;
void conquer(int arr[],int left,int mid,int right){
    int n1=mid-left+1;
    int n2=right-mid;
    int l[n1],r[n2];
    for(int i=0;i<n1;i++){
        l[i]=arr[left+i];
    }    
    for(int j=0;j<n2;j++){
        r[j]=arr[mid+1+j];
    }

    int i=0,j=0,k=left;
    while(i<n1&&j<n2){
        if(l[i]<=r[j]){
            arr[k++]=l[i++];
        }
        else{
            arr[k++]=r[j++];
            }
    }
    while(i<n1) 
    arr[k++]=l[i++];
    while(j<n2)
    arr[k++]=r[j++];
}
void divide(int arr[],int left,int right){
    if(left<right){
        int mid=(left+right)/2;
        divide(arr,left,mid);
        divide(arr,mid+1,right);
        conquer(arr,left,mid,right);
    }
}



int main(){
    int arr[50],i,n;
    cout<<"Enter the no of elements"<<endl;
    cin>>n;
    cout<<"Enter the elements"<<endl;
    for(i=0;i<n;i++){
        cin>>arr[i];
    }
    divide(arr,0,n-1);
    cout<<"the sorted array is "<<endl;
    for(int i=0;i<n;i++)
    cout<<arr[i]<<" ";
}