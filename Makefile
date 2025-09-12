#!/bin/sh
cc = gcc
install:
	cp config.def.h config.h
	cc -o montecarlo.c montecarlo
	chmod +x montecarlo
 
