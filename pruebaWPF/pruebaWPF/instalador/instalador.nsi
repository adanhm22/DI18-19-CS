#salida

outFile "Gestion de avituallamientos.exe"

#informacion adicional
!define PRODUCT_NAME "Gestion de avituallamientos"

!define SETUP_NAME "Gestion de avituallamientos"

!define PRODUCT_VERSION "1.0"

Name "Gestion de avituallamientos"

#carpeta de instalacion por defecto

installDir $PROGRAMFILES\GestionAvituallamientos



#permisos de administración

RequestExecutionLevel admin



#pantallas que mostrar al usuario

Page directory

Page instfiles



#idioma español

!include "MUI.nsh"

!insertmacro MUI_LANGUAGE "Spanish"



Section

	#seleccionamos la carpeta de instalación

	SetOutPath $INSTDIR

	

	#escribimos el unistalador

	writeUninstaller "$INSTDIR\uninstall.exe"

	

	#añadimos los archivos que queremos en la instalación


	File "/oname=GestionAvituallamientos.exe" "..\bin\Debug\pruebaWPF.exe" 

	

	#creamos los enlaces directos

	CreateDirectory "$SMPROGRAMS\GestionAvituallamientos"

	createShortCut "$SMPROGRAMS\GestionAvituallamientos\Desinstalar.lnk" "$INSTDIR\uninstall.exe"

	createShortCut "$SMPROGRAMS\GestionAvituallamientos\Gestion.lnk" "$INSTDIR\GestionAvituallamientos.exe"

	createShortCut "$DESKTOP\GestionAvituallamientos.lnk" "$INSTDIR\GestionAvituallamientos.exe"

 	

	#añadimos la información del registro

	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GestionAvituallamientos" \
                 "DisplayName" "GestionAvituallamientos"

	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GestionAvituallamientos" \
                 "Publisher" "Adán - Desarrollo de interfaces"

	WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GestionAvituallamientos" \
                 "UninstallString" "$\"$INSTDIR\uninstall.exe$\""

	

SectionEnd





#definimos el desinstalador

Section "uninstall"

	#borramos el desinstalador

	delete "$INSTDIR\uninstall.exe"

	

	#borramos cada archivo individual

	delete "$INSTDIR\GestionAvituallamientos.exe"

	

	#borramos los enlaces directos

	delete "$SMPROGRAMS\GestionAvituallamientos\Gestion.lnk"

	delete "$SMPROGRAMS\GestionAvituallamientos\Desinstalar.lnk"

	delete "$DESKTOP\GestionAvituallamientos.lnk"

	RmDir "$SMPROGRAMS\GestionAvituallamientos"

	

	#borramos la carpeta de instalación

	RmDir "$INSTDIR"

	#borramos la clave del registro

	DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\GestionAvituallamientos"

SectionEnd