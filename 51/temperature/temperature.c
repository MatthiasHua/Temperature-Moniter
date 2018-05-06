#include "reg52.h"  
#include "ds18b20.h"

bit read_flag = 0;

void cls_buzz()
{
	P2 = (P2&0x1F|0xA0);
	P0 = 0x00;
	P2 &= 0x1F;
}


// 读取串口输入，当输入符合要求时设定标志read_flag为1
void serial() interrupt 4 using 3 {
	unsigned char ch;
	if (RI){
		RI = 0 ;
		ch = SBUF;
		if (ch == ' ')
			read_flag = 1; 
	}
}

// 串口初始化
void init_uart() {  
		PCON &= 0x7F;      
		SCON = 0x50;          
		AUXR &= 0xBF;         
		AUXR &= 0xFE;        
		TMOD &= 0x0F;       
		TMOD |= 0x20;         
		TL1 = 0xFD;      
		TH1 = 0xFD;      
		ET1 = 0;          
		TR1 = 1;        
		EA = 1;
		ES = 1;
}  

// 串口 发送一个字节
void Serial_Send_Char(unsigned char c) {
    SBUF = c;
    while(!TI);
		TI=0;
}

// 串口 发送一个16位无符号整数
void Serial_Send_Integer(unsigned int num) {
		Serial_Send_Char(num / 256);
		Serial_Send_Char(num % 256);
}

// 等待请求 获得请求时通过串口返回温度
void run() {
	  int temperature = read_temperature();
	  if(read_flag == 1) {
		  	ES = 0;
        Serial_Send_Integer(temperature);
				ES = 1;
				read_flag = 0;
		}
}

void main() {		
    cls_buzz();
    init_uart();
    while(1)
		    run();
}
