/*
 */

#include <avr/io.h>

int main(void)
{
    DDRD = 0b10010100; //0 eingang 1 ausgang
    PORTD = 0b10010100;
    // Insert code

    while(1)
    ;

    return 0;
}
