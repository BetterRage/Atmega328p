/*
 */

#include <avr/io.h>

/****************************

*  testATmega328

*  Blink LED

*  Josef Pedevilla

*  24.10.2020

*****************************/



#include <avr/io.h>

#define  F_CPU 16000000UL

#include <util/delay.h>



int main(void)

{

    DDRB = 0b00100000;



    while(1)

    {

        PORTB ^= 1<<PB5;

        _delay_ms(1000);

    }

    return 0;

}
