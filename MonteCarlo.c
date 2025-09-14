#include <math.h>
#include <stdio.h>
#include "config.h"
#include <stdbool.h>
#include <ncurses.h>
#include <stdlib.h>
#include <string.h>

int main() {
	printf("Welcome to the simulator\n");
	printf("Do you want to use modern terminal mode or legacy gui mode, yes or no?\n");
	char userchoiceinter[100];
	fgets(userchoiceinter, 10, stdin);
	// 'cklig nested if men finns inget b'ttre.
	if (strcmp(userchoiceinter, "yes")==0) {
		//guiinterface();
	} else if (strcmp(userchoiceinter, "no")==0) {
		//terminalinterface();
	} else {
		printf("please give a valid response");
	}
}
//void guiinterface() {
//}
//void terminainterface() {
//}
