#include "bgz_core.h"
#include "Modules/ModuleManager.h"

#include "log.h"

void fbgz_core::StartupModule()
{
    //Any code to execute on module start up
    UE_LOG(BGZLog, Log, TEXT("Starings module"));
};

void fbgz_core::ShutdownModule()
{
    UE_LOG(BGZLog, Log, TEXT("Ending module!!"));
};

IMPLEMENT_PRIMARY_GAME_MODULE(fbgz_core, bgz_core, "bgz_core");