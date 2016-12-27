FROM microsoft/runtime
WORKDIR /app
COPY /d .
EXPOSE 5002
ENTRYPOINT ["./chat-service-1"]
