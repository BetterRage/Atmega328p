#include "../Headerfunktionen/lcd.h"
#include <avr/io.h>

int main(void)
{
    lcd_init();
    lcd_write(5);
    while(1)
    {

    }


    return 0;
}
