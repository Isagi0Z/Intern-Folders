#include<iostream>
using namespace std;

int main() {
    int i, j, n, arr[50];

    cout << "Enter the number of elements: ";
    cin >> n;

    cout << "Enter the numbers: ";
    for(i = 0; i < n; i++) {
        cin >> arr[i];
    }

    
    for(i=0;i<n-1;i++){
        for(j=0;j<n-i-1;j++){
            if(arr[j]>arr[j+1]){
                int temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
        }
    }

   
    cout << "Sorted array: ";
    for(i = 0; i < n; i++) {
        cout << arr[i] << " ";
    }

    return 0;
}
