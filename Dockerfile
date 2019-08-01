FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /app

COPY . ./
RUN dotnet restore
WORKDIR /app/src/DddMelb2019.Web
ARG buildConfig=Debug
RUN dotnet publish -c $buildConfig -o ../../publish

FROM microsoft/dotnet:2.2-aspnetcore-runtime AS runtime
WORKDIR /app
COPY --from=build /app/publish .
RUN apt-get update 
RUN apt-get install -y --no-install-recommends apt-utils 
RUN apt-get install -y curl unzip procps
RUN curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /publish/vsdbg;
ENTRYPOINT ["dotnet", "DddMelb2019.Web.dll"]