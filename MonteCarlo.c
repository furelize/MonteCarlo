#include <math.h>
#include <stdio.h>
#include "config.h"
#include <stdbool.h>
#include <ncurses.h>
#include <stdlib.h>
#include <string.h>

int main() {
	printf("Welcome to the simulator\n");
	printf("Do you want to use modern terminal mode or legacy gui mode, yes or not?\n");
	char userchoiceinterface[3];
	while ((strcmp(userchoiceinterface,"ter") !=  0) || (strcmp(userchoiceinterface,"gui") != 0 )) {
	fgets(userchoiceinterface, 3, stdin);
	if ((strcmp(userchoiceinterface,"gui") !=  0) || (strcmp(userchoiceinterface,"ter") != 0 )) {
		printf("please give an valid response ");
	}
	}
}
//void guiinterface() {
//}
//void terminainterface() {
//}
