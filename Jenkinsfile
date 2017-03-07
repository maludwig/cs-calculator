pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'echo msbuild'
                bat 'echo "C:\\Users\\turiy\\Documents\\Visual Studio 2015\\Projects\\cs-calculator\\cs-calculator\\cs-calculator.csproj"'
                bat 'echo msbuild "C:\\Users\\turiy\\Documents\\Visual Studio 2015\\Projects\\cs-calculator\\cs-calculator\\cs-calculator.csproj" /t:Clean;Build'
                bat 'msbuild "C:\\Users\\turiy\\Documents\\Visual Studio 2015\\Projects\\cs-calculator\\cs-calculator\\cs-calculator.csproj" /t:Clean;Build'
            }
        }
    }
}