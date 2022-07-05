#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"
#include "Modules/ModuleManager.h"

class fbgz_core : public IModuleInterface 
{
    public:
        static inline fbgz_core& Get()
        {
            return FModuleManager::LoadModuleChecked<fbgz_core>("bgz_core");
        };

        static inline bool IsAvailable()
        {
            return FModuleManager::Get().IsModuleLoaded("bgz_core");
        };

        virtual void StartupModule() override;
        virtual void ShutdownModule() override;
};
