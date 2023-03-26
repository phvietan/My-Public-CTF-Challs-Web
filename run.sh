#!/bin/bash

sudo docker stop public-ctf-web
sudo docker rm public-ctf-web

sudo docker build -t public-ctf-web .
sudo docker run --name public-ctf-web -dp 127.0.0.1:1212:80 --restart always -t public-ctf-web

