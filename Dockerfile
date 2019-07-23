FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app

COPY . ./
RUN dotnet restore
WORKDIR /app/src/DddMelb2019.Web
ARG buildConfig=Release
RUN dotnet publish -c $buildConfig -o ../../publish

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "DddMelb2019.Web.dll"]