FROM microsoft/dotnet:runtime
WORKDIR /app
COPY /out .
EXPOSE 5002
ENTRYPOINT ["./chat-service-1"]
