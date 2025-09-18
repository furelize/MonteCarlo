int guiinterface() {
        char datadir[] = malloc(256);
	char letter [2];
	int i;
	initscr();
        printw("Welcome to the gui version of the simulator!\n");
        printw("Please enter the directory of the data ");
        refresh();
        while ((letter != '\0') && i < strlng(datadir)) {
	letter [1] = getch();
	
	i+1 = i;
	}
	free(256);
        endwin();
}
int terminalinterface() {
        printf("please enter the directory of the data ");
        return 0;
}

