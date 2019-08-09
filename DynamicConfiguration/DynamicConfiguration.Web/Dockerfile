#Depending on the operating system of the host machines(s) that will build or run the containers, the image specified in the FROM statement may need to be changed.
#For more information, please see https://aka.ms/containercompat

FROM microsoft/dotnet:2.1-aspnetcore-runtime-nanoserver-1709 AS base
WORKDIR /app
EXPOSE 49818
EXPOSE 44352

FROM microsoft/dotnet:2.1-sdk-nanoserver-1709 AS build
WORKDIR /src
COPY ["DynamicConfiguration.Web/DynamicConfiguration.Web.csproj", "DynamicConfiguration.Web/"]
RUN dotnet restore "DynamicConfiguration.Web/DynamicConfiguration.Web.csproj"
COPY . .
WORKDIR "/src/DynamicConfiguration.Web"
RUN dotnet build "DynamicConfiguration.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "DynamicConfiguration.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DynamicConfiguration.Web.dll"]