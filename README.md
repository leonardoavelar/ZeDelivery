# Contato

Leonardo Avelar
leonardoavelar@terra.com.br
(31) 98836-7224
(11) 93336-7224

# Desafio de Backend

A API Ze Delivery foi implementada utilizando a tecnologia C# em .Net Core 3.1 e MongoDB.
A aplicação gerencia o cadastro de parceiros da plataforma Ze Delivery.

A aplicação foi desenvolvida e estruturada da seguinte forma:
    * API (Camada da controller)
    * Application (Camada de integração entre controller e fronteiras)
    * DI (Dependency Injection)
    * Domain (Camada de controle de entidades e interfaces)
    * Infra (Camada de integração com as fronteiras)

# Pré-requisitos para executar a aplicação
    * IDE para C# com .Net Core 3.1
    * Docker Desktop
    * MongoDBCompass
    * Postman

# Links

Imagens Docker
https://hub.docker.com/u/leonardoavelar

GitHub
https://github.com/leonardoavelar/ZeDelivery


# Dicas para executar aplicação

Para executar a aplicação é essencial ter o MongoDB. Caso não tenha um servidor local, favor utilizar a imagem abaixo para realizar o teste.
Para preparar o ambiente utilizando o Docker, bastar utilizar os comandos abaixo para baixar a imagem e subir um container com MongoDB.

-- Comando para disponibilizar o MongoDB
docker run -d -p 27017:27017 --name mongodb leonardoavelar/mongodb:latest

-- Comando para descobrir o IP do container do MongoDB
-- O IP é essencial para ajustarmos a connection string no arquivo de configuração
docker inspect -f '{{range.NetworkSettings.Networks}}{{.IPAddress}}{{end}}' mongodb

-- Arquivo de configuração (appsettings.json)
  "PartnerDatabaseSettings": {
    "ConnectionString": "mongodb://172.17.0.2:27017",
    "DatabaseName": "ze_delivery",
    "CollectionName": "partner"
  }


Esta sendo disponibilizado junto ao projeto, uma collection para testes via Postman.
Os comandos GET, POST, PUT e DELETE estão todos disponíveis na collection, incluindo carga da massa com diversos parceiros.


Infelizmente, a regra abaixo não foi implementada devido a falta de entendimento do algoritmo de pesquisa por coordenada.
Caso haja oportunidade de uma explicação, posso implementar posteriormente.

1.3. Buscar parceiro:
Dada uma localização pelo usuário da API (coordenadas `long` e `lat`), procure o parceiro que esteja **mais próximo** e **que cuja área de cobertura inclua** a localização.