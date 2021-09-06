#include "../HeaderFunktionen/mydelay.h"
#include "../HeaderFunktionen/pinauslesen.h"
#include "../HeaderFunktionen/sevensegment.h"
#include <avr/io.h>

int main(void)
{
    DDRD=0xFF;
    DDRB=0b00000011;
    DDRC=0x00;
    PORTC=0x01;
    uint8_t tasterjetzt=0;
    uint8_t tasterdavor=1;
    uint8_t weiterzaehlen=1;
    uint8_t zahl=1;

    while(1)
    {

        delay(10);
        tasterjetzt=pinlesen(0);
        if(tasterjetzt&&!tasterdavor)
        {
            weiterzaehlen^=1;
        }
        tasterdavor=tasterjetzt;
        if(weiterzaehlen)
            showdigit(zahl++);
        if(zahl==6)
            zahl=1;
    }
    return 0;
}

