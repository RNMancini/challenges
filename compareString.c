#include <stdio.h>
#include <string.h>

int main()
{
    char a[1], b[1];
    
    printf("Enter a string\n");
    gets(a);
    
    printf("Enter a string\n");
    gets(b);
    
    if (strcmp(a,b) == 0)
        printf("The strings are equal.\n");
    else
        printf("The strings are not equal.\n");
        
    return 0;
}