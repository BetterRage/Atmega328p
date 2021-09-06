#include "../Headerfunktionen/UART.h"
#include "../Headerfunktionen/mydelay.h"
#include "../Headerfunktionen/pinauslesen.h"
#include <avr/io.h>
#include <stdlib.h>
int main(void)      //AVCC = 4,524
{
    uint8_t x;
    char  strx[5];
    DDRD=0b00011100;
    init_usart();
    while(1)
    {
        x=analoglesen8(0);
        itoa(x,strx,10);
        (x>400)?((x>500)?(PORTD=0x10):(PORTD=0x08)):(PORTD=0x04);
        _puts(strx);
        _newline();
        delay(50);

    }
    return 0;
}
