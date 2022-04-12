# Build runtime image
FROM mcr.microsoft.com/dotnet/runtime:6.0
WORKDIR /app
RUN apt-get update  
COPY PdfTest/bin/Debug/net6.0 .
ENTRYPOINT ["dotnet", "PdfTest.dll"]