Objy deletefd -boot testfd.boot
del ..\pdd\model.pdd
objy createfd -fdname testfd
objy do -infile allschema.txt -boot testfd.boot
oofdtopdd -outfile ..\pdd\model.pdd -publicclasses testfd.boot
oopddtoapp ..\pdd\model.pdd ..\CarDesign.Model.Persistent

