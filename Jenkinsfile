pipeline {
    agent any
    stages {
        stage('Build') {
            steps {
                bat 'echo msbuild'
                bat 'echo ".\\cs-calculator\\cs-calculator.csproj"'
                bat 'echo msbuild ".\\cs-calculator\\cs-calculator.csproj" /t:Clean;Build'
                bat 'msbuild ".\\cs-calculator\\cs-calculator.csproj" /t:Clean;Build'
            }
        }
    }
}