   M S B A M L   `   `   `  ����  Avituallamiento*    $AplicacionAvituallamiento.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��323��6   $	��642��6)   .��5      � .+�5   
   o� -   5         o�Name$ MenuGeneral��5      $��0,0,10,0q�6$   $��25��66   $	��Top=�6B   $��2��6Z   .@�5      m� -   5         m�Name$ MenuItemArchivo��5      $��Archivo��60   .@�5	      m� -   5        $ MenuItemNuevaCarrera��5	      $��Nueva Carrera...��69   $
��Left=�6w   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6�   m� 5
      -   5        $ MenuItemNuevoContacto��5
      $��Nuevo Contacto ...��6:   $
��Left=�6V   $ Display=�6�   m� 5      -   5        $" MenuItemNuevoAvituallamiento��5      $��Nuevo Avituallamiento...��6A   $
��Left=�6�   $ Display=�6�   5      m� 5      -   5        $ MenuItemAlmacen��5      $��Almacen��60   .@�5      m� -   5        $ MenuItemProducto��5      $��Almacenar Producto...��67   $
��Left=�6W   $ Display=�6�   m� 5      -   5        $ MenuItemConsultarAlmacen��5      $��Consultar almacen...��6?   $
��Left=�6_   $ Display=�6�   5      5      �� 5   
   -	   5         ��Name$ 	BtnBorrar��5      $��Borrar��6$   $��367,262,0,0q�65   $��20��6J   $	��Top=�6V   $
��Left=�6n   $��75��6�   6�   �� 5   
   -
   5        $ BtnModificar��5      $��	Modificar��6'   $��458,262,0,0q�6;   $
��Left=�6P   $��75��6k   $��20��6v   $	��Top=�6�   6�   �� 5   
   -   5        $ BtnConsultar��5      $��	Consultar��6'   $��549,262,0,0q�6;   $
��Left=�6P   $��75��6k   $��20��6v   $	��Top=�6�   6�   �� 5   
   $��Lista de contactos��6   $
��Left=�6-   $��	25,54,0,0q�6H   $	��Top=�6[   �� 5   
   -   5         ��Name$ ComboBoxContactos��5      $
��Left=�6a   $��	25,85,0,0q�6|   $	��Top=�6�   $	��120��6�   ��6.   ��  �� Path$ listaPersonasContacto�6�   �� 5   
   $��Lista Carreras��6   $
��Left=�6)   $��
203,54,0,0q�6D   $	��Top=�6X    J� RenderTransformOrigin$ 0.447,1.269&�6p   $��26��6�   $	��100��6�   �� 5   
   -   5        $ ComboBoxCarreras��5      $
��Left=�6X   $��
203,85,0,0q�6s   $	��Top=�6�   $	��120��6�   ��6-   �� $ listaCarreras�6�   �� 5   
   $��Lista Avituallamientos��6   $
��Left=�61   $��
413,56,0,0q�6L   $	��Top=�6`   �� 5   
   -   5        $ ComboBoxAvituallamientos��5      $
��Left=�65   $��
413,82,0,0q�6�   $	��Top=�6�   $	��120��6�   ��6P   �� $ listaAvituallamientos�6�   5      5      