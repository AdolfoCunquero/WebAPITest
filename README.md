docker build -t web-api-test .
docker run -it --rm -p 5000:80 --name web-api-test web-api-test