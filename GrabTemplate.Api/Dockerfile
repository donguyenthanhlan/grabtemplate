#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1803 AS base
WORKDIR /app
EXPOSE 50799
EXPOSE 44386

FROM microsoft/dotnet:2.1-sdk-nanoserver-1803 AS build
WORKDIR /src
COPY ["GrabTemplate.Api/GrabTemplate.Api.csproj", "GrabTemplate.Api/"]
RUN dotnet restore "GrabTemplate.Api/GrabTemplate.Api.csproj"
COPY . .
WORKDIR "/src/GrabTemplate.Api"
RUN dotnet build "GrabTemplate.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "GrabTemplate.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GrabTemplate.Api.dll"]