#include <stdio.h>
#include <string.h>

int main() {
   char block = '#';
   char* block_line[10];
   int pyramid_height = sizeof(block_line);
   
   
   for(int i = 0; i < pyramid_height; i+=strlen(block)){
       block_line[i] = block;
       printf("%s", block_line);
   } 
}
