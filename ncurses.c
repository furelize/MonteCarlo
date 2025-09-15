int guiinterface() {
        initscr();
        printw("Welcome to the gui version of the simulator!\n");
        printw("Please enter the directory of the data ");
        refresh();
        getch();
        endwin();
}
int terminalinterface() {
        printf("please enter the directory of the data ");
        return 0;
}

