#include "ds18b20.h"

void Delay_OneWire(unsigned int t) {  
	int i;
  while(t--)  
		for(i = 0; i < 12; i++);  
} 

bit init_ds18b20()  
{  
    bit initflag = 0;  
    DQ = 1;  
    Delay_OneWire(12);  
    DQ = 0;  
    Delay_OneWire(80);   
    DQ = 1;  
    Delay_OneWire(10);   
    initflag = DQ;      
    Delay_OneWire(5);  
    return initflag;  
}  
      
      

void Write_DS18B20(unsigned char dat) {  
    unsigned char i;  
    for(i=0;i<8;i++) {  
				DQ = 0;  
				DQ = dat&0x01;  
				Delay_OneWire(5);  
				DQ = 1;  
				dat >>= 1;  	
    }  
    Delay_OneWire(5);  
}  
      

unsigned char Read_DS18B20(void) {  
    unsigned char i;  
    unsigned char dat;  
        
    for(i=0;i<8;i++) {  
				DQ = 0;  
				dat >>= 1;  
				DQ = 1;  
				if(DQ)
						dat |= 0x80; 
				Delay_OneWire(5);  
    }  
    return dat;  
}  

//获取温度并返回
int read_temperature()  
{  
  unsigned char low,high;  
  int temp;  
 
  init_ds18b20();  
  Write_DS18B20(0xcc);  
  Write_DS18B20(0x44);  
  Delay_OneWire(200);  
  init_ds18b20();  
  Write_DS18B20(0xcc);  
  Write_DS18B20(0xbe);  
  low=Read_DS18B20();  
  high=Read_DS18B20();  
  temp=(high&0x0f)<<8|low; 
  temp=temp*0.0625*10+0.5; 
  return temp;    
} 