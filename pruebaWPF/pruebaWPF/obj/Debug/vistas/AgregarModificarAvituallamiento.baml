   M S B A M L   `   `   `  ����D  @pruebaWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:pruebaWPF.vistaspruebaWPF.vistas  5   	   6    0pruebaWPF.vistas.AgregarModificarAvituallamiento   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:pruebaWPF.vistas     5   	     � Title$%  AgregarModificarAvituallamiento��5   	   $��440.497��61   $��416.568��6B   .��5	      � .+�5
   
   �� $��Carrera��6   $
��Left=�6"   $��	10,10,0,0q�6=   $	��Top=�6P   $	��125��6h   �� 5   
   $��Punto kilometrico��6   $
��Left=�6,   $��	10,60,0,0q�6G   $	��Top=�6Z   $	��125��6r   �� 5   
   $��Persona de contacto��6   $
��Left=�6.   $��
10,109,0,0q�6I   $	��Top=�6]   $	��125��6u   �� 5   
   $��
Materiales��6   $
��Left=�6%   $��
10,166,0,0q�6@   $	��Top=�6T   $	��125��6l   �� 5   
   -   5         ��Name$ botonAgregarModificar��5      $��Agregar��60   $
��Left=�6B   $��162,378,0,0q�6]   $	��Top=�6r   $��75��6�    J� RenderTransformOrigin$ 0.627,0.373&�6�   6�   �� 5   
   -   5         ��Name$ comboCarreras��5      $
��Left=�6*   $��
150,14,0,0q�6E   $	��Top=�6Y   $	��120��6q   ��6}   ��  �� Path$ Carreras��� 5   
   -   5        $ botonNuevaCarrera��5      $��nueva��6,   $
��Left=�6<   $��
308,13,0,0q�6W   $	��Top=�6k   $��75��6�   6�   �� 5   
   $
��Left=�6   $��23��6-   $��
150,60,0,0q�69    �� TextWrapping$
 Wrap=�6M   $	��Top=�6�   $	��159��6�   ��6a   �� $&  Avituallamiento.PuntoKilometrico�6�   �� 5   
   -   5        $ comboPersonas��5      $
��Left=�6*   $��150,109,0,0q�6E   $	��Top=�6Z   $	��120��6r   $ 0.003,0.657&�6~   ��6�   �� $ Personas��� 5   
   -   5        $ botonNuevaPersona��5      $��Nueva��6,   $
��Left=�6<   $��308,109,0,0q�6W   $	��Top=�6l   $��75��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ gridMateriales��5      $
��Left=�6+   $	��137��6F   $��
37,213,0,0q�6S   $	��Top=�6g   $	��334��6      
IsReadOnly . ��6�   �� $( "Avituallamiento.MaterialDisponible��� 5   
   -   5        $ botonAgregarMaterial��5      $��Agregar��6/   $
��Left=�6A   $��308,172,0,0q�6\   $	��Top=�6q   $��75��6�   6�   �� 5   
   -   5        $ botonEliminarMaterial��5      $��Eliminar��60   $
��Left=�6C   $��195,172,0,0q�6^   $	��Top=�6s   $��75��6�   {�.  6�   5      5      