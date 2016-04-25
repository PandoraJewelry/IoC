# Pandors IoC Extensions

## Introduction
The Pandora.IoC library provides basic IoC interfaces for general tasks that otherwise lack them.
The Pandora.IoC.WebJobs library provides dependency injection helpers for StructureMap used with Azure WebJobs

## Our use case
We use [Azure WebJobs][1] to offload long running processes. Some of these jobs can be complex and so they get unit tests. IoC is one of the corner stones of IoC so these assemblies were made.

## Installation

You can obtain it [through Nuget][0] with:

    Install-Package Pandora.IoC
    Install-Package Pandora.IoC.WebJobs

Or **clone** this repo and reference it.

[\\]: Refrences
[0]: https://www.nuget.org/packages/Pandora.IoC
[1]: https://github.com/Azure/azure-webjobs-sdk
