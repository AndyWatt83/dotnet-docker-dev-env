
FROM mcr.microsoft.com/vscode/devcontainers/base:ubuntu-20.04
RUN echo "Acquire::Check-Valid-Until \"false\";\nAcquire::Check-Date \"false\";" | cat > /etc/apt/apt.conf.d/10no--check-valid-until
RUN wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
RUN sudo dpkg -i packages-microsoft-prod.deb
RUN sudo apt-get update
RUN sudo apt-get install -y apt-transport-https
RUN sudo apt-get update
RUN sudo apt-get install -y dotnet-sdk-5.0