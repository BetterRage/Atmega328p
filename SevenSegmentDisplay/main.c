#include "../Headerfunktionen/mydelay.h"
#include "../Headerfunktionen/drehschalter.h"
#include "../Headerfunktionen/sevensegment.h"
#include <avr/io.h>



int main(void)
{
    DDRD=0b111111<<2;  //6 bits des D registers für die 7 segment anzeige
    DDRB=0b00000011;        //2 bits des B registers
    DDRC=0x00;        //A0 bis A3 auf Eingang
    PORTC=0x0F;       //A0 bis A3 auf HIGH um PU Widerstand einzuschalten

    uint8_t led=0;
    PORTD=0x00;
    while(1)
    {
        led=get4bit()%10;
        showdigit(led);
    }
    return 0;
}

