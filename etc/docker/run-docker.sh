#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p d55e63d5-6dcf-48cd-884a-1b8b90c9b97a -t
    fi
    cd ../
fi

docker-compose up -d
