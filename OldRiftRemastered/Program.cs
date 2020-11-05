﻿using LeagueToolkit.Helpers.Structures;
using LeagueToolkit.Helpers.Structures.BucketGrid;
using LeagueToolkit.IO.MapGeometry;
using LeagueToolkit.IO.OBJ;
using LeagueToolkit.IO.PropertyBin;
using LeagueToolkit.IO.WorldGeometry;
using ImageMagick;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using SharpGLTF.Geometry.VertexTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using LeagueToolkit.IO.NVR;
using LeagueToolkit.IO.SimpleSkinFile;
using System.Numerics;

namespace OldRiftRemastered
{
    class Program
    {
        static void Main(string[] args)
        {
          
            HalloweenRift();
        }

        static void OldRiftRemastered2()
        {
            MapGeometry mgeo = new MapGeometry(@"K:\Riot Games\LeagueofLegendsRAW\LeagueofLegendsRAW\Maps\Shipping\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo");
            mgeo.Models.Clear();

            //ModelsForOldRift

            //Layer 1 (Right now only "All Layers" for testing map)
            OBJFile object1 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room1.obj");
            OBJFile object2 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room2.obj");
            //OBJFile object3 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room3.obj"); //Decal
           // OBJFile object4 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room4.obj"); //Decal
            OBJFile object5 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room5.obj");
            OBJFile object6 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room6.obj");
            OBJFile object7 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room7.obj");
            OBJFile object8 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room8.obj");
            OBJFile object9 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room9.obj");
            OBJFile object10 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room10.obj");
            OBJFile object11 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room11.obj");
            OBJFile object12 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room12.obj");
            OBJFile object13 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room13.obj");
            OBJFile object14 = new OBJFile(@"K:\Riot Games\LeagueSkins\DefaultTestMap\Models\decal.obj"); //Decal
            OBJFile object15 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room15.obj");
          //  OBJFile object16 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room16.obj"); //Chaos_dirt Lanes + Jungle
            OBJFile object17 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room17.obj");
          //  OBJFile object18 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room18.obj"); //Decal
            OBJFile object19 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room19.obj");
            OBJFile object20 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room20.obj");
            OBJFile object21 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room21.obj");
            OBJFile object22 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room22.obj");
            OBJFile object23 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room23.obj");
            OBJFile object24 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room24.obj");
            OBJFile object25 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room25.obj");
          //  OBJFile object26 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room26.obj"); //Decal
            OBJFile object27 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room27.obj");
            OBJFile object28 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room28.obj");
            OBJFile object29 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room29.obj");
            OBJFile object30 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room30.obj");
          //  OBJFile object31 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room31.obj"); //Decal
            OBJFile object32 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room32.obj");
            OBJFile object33 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room33.obj");
            OBJFile object34 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room34.obj");
           // OBJFile object35 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room35.obj"); //Decal
            OBJFile object36 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room36.obj");
            OBJFile object37 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room37.obj");
            OBJFile object38 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room38.obj");
            OBJFile object39 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room39.obj");
            OBJFile object40 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room40.obj");
            OBJFile object41 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room41.obj");
            OBJFile object42 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room42.obj");
          //  OBJFile object43 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room43.obj"); //Decal
            OBJFile object44 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room44.obj");
            OBJFile object45 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room45.obj");
           // OBJFile object46 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room46.obj"); //Decal
           // OBJFile object47 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room47.obj"); //Decal
          //  OBJFile object48 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room48.obj"); //Decal
            OBJFile object49 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room49.obj");
           // OBJFile object50 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room50.obj"); //SR_Lane_Tile Lane
            OBJFile object51 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room51.obj");
            OBJFile object52 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room52.obj");
          //  OBJFile object53 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room53.obj"); //Decal
            OBJFile object54 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room54.obj");
           // OBJFile object55 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room55.obj"); //Decal
           // OBJFile object56 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room56.obj"); //Decal
           // OBJFile object57 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room57.obj"); //Decal
            OBJFile object58 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room58.obj");
            OBJFile object59 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room59.obj");
            OBJFile object60 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room60.obj");
            OBJFile object61 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room61.obj");
            OBJFile object62 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room62.obj");
            OBJFile object63 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room63.obj"); //chaos_dirt River
            OBJFile object64 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room64.obj");
            OBJFile object65 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room65.obj");
            OBJFile object66 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room66.obj");
          //  OBJFile object67 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room67.obj"); //order_tile_floor Base
            OBJFile object68 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room68.obj");
          //  OBJFile object69 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room69.obj"); //Decal
            OBJFile object70 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room70.obj");
            OBJFile object71 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room71.obj");
          //  OBJFile object72 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room72.obj"); //Decal
            OBJFile object73 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room73.obj");
            OBJFile object74 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room74.obj");
            OBJFile object75 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room75.obj");
            OBJFile object76 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room76.obj");
          //  OBJFile object77 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room77.obj"); //Decal
            OBJFile object78 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room78.obj");
            OBJFile object79 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room79.obj");
          //  OBJFile object80 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room80.obj"); //Decal
            OBJFile object81 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room81.obj");
            OBJFile object82 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room82.obj");
            OBJFile object83 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room83.obj");
            OBJFile object84 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room84.obj");
            OBJFile object85 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room85.obj");
            OBJFile object86 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room86.obj");

            //BakedTerrain
            OBJFile object87 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain1.obj");
            OBJFile object88 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain2.obj");
            OBJFile object89 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain3.obj");
            OBJFile object90 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain4.obj");
            OBJFile object91 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain5.obj");
            OBJFile object92 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain6.obj");
            OBJFile object93 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain7.obj");
            OBJFile object94 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain8.obj");
            OBJFile object95 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain9.obj");
            OBJFile object96 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain10.obj");
            OBJFile object97 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain11.obj");
            OBJFile object98 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain12.obj");
            OBJFile object99 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain13.obj");
            OBJFile object100 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain14.obj");
            OBJFile object101 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain15.obj");
            OBJFile object102 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain16.obj");
            OBJFile object103 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain17.obj");
            OBJFile object104 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain18.obj");
            OBJFile object105 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain19.obj");
            OBJFile object106 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain20.obj");
            OBJFile object107 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain21.obj");
            OBJFile object108 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain22.obj");
            OBJFile object109 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain23.obj");
            OBJFile object110 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain24.obj");
            OBJFile object111 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain25.obj");
            OBJFile object112 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain26.obj");
            OBJFile object113 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain27.obj");
            OBJFile object114 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain28.obj");
            OBJFile object115 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain29.obj");
            OBJFile object116 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain30.obj");
            OBJFile object117 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain31.obj");
            OBJFile object118 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain32.obj");
            OBJFile object119 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain33.obj");
            OBJFile object120 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain34.obj");
            OBJFile object121 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain35.obj");
            OBJFile object122 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\terrain36.obj");

            //NewInstancesForOldRift
            AddModel(object1, "MapGeo_Instance_0");
            AddModel2(object2, "MapGeo_Instance_1");
           // AddModel3(object3, "MapGeo_Instance_2");
           // AddModel4(object4, "MapGeo_Instance_3");
            AddModel5(object5, "MapGeo_Instance_4");
            AddModel6(object6, "MapGeo_Instance_5");
            AddModel7(object7, "MapGeo_Instance_6");
            AddModel8(object8, "MapGeo_Instance_7");
            AddModel9(object9, "MapGeo_Instance_8");
            AddModel10(object10, "MapGeo_Instance_9");
            AddModel11(object11, "MapGeo_Instance_10");
            AddModel12(object12, "MapGeo_Instance_11");
            AddModel13(object13, "MapGeo_Instance_12");
            AddModel14(object14, "MapGeo_Instance_13");
            AddModel15(object15, "MapGeo_Instance_14");
           // AddModel16(object16, "MapGeo_Instance_15");
            AddModel17(object17, "MapGeo_Instance_16");
           // AddModel18(object18, "MapGeo_Instance_17");
            AddModel19(object19, "MapGeo_Instance_18");
            AddModel20(object20, "MapGeo_Instance_19");
            AddModel21(object21, "MapGeo_Instance_20");
            AddModel22(object22, "MapGeo_Instance_21");
            AddModel23(object23, "MapGeo_Instance_22");
            AddModel24(object24, "MapGeo_Instance_23");
            AddModel25(object25, "MapGeo_Instance_24");
           // AddModel26(object26, "MapGeo_Instance_25");
            AddModel27(object27, "MapGeo_Instance_26");
            AddModel28(object28, "MapGeo_Instance_27");
            AddModel29(object29, "MapGeo_Instance_28");
            AddModel30(object30, "MapGeo_Instance_29");
           // AddModel31(object31, "MapGeo_Instance_30");
            AddModel32(object32, "MapGeo_Instance_31");
            AddModel33(object33, "MapGeo_Instance_32");
            AddModel34(object34, "MapGeo_Instance_33");
          //  AddModel35(object35, "MapGeo_Instance_34");
            AddModel36(object36, "MapGeo_Instance_35");
            AddModel37(object37, "MapGeo_Instance_36");
            AddModel38(object38, "MapGeo_Instance_37");
            AddModel39(object39, "MapGeo_Instance_38");
            AddModel40(object40, "MapGeo_Instance_39");
            AddModel41(object41, "MapGeo_Instance_40");
            AddModel42(object42, "MapGeo_Instance_41");
           // AddModel43(object43, "MapGeo_Instance_42");
            AddModel44(object44, "MapGeo_Instance_43");
            AddModel45(object45, "MapGeo_Instance_44");
           // AddModel46(object46, "MapGeo_Instance_45");
           // AddModel47(object47, "MapGeo_Instance_46");
           // AddModel48(object48, "MapGeo_Instance_47");
            AddModel49(object49, "MapGeo_Instance_48");
           // AddModel50(object50, "MapGeo_Instance_49");
            AddModel51(object51, "MapGeo_Instance_50");
            AddModel52(object52, "MapGeo_Instance_51");
           // AddModel53(object53, "MapGeo_Instance_52");
            AddModel54(object54, "MapGeo_Instance_53");
           // AddModel55(object55, "MapGeo_Instance_54");
           // AddModel56(object56, "MapGeo_Instance_55");
           // AddModel57(object57, "MapGeo_Instance_56");
            AddModel58(object58, "MapGeo_Instance_57");
            AddModel59(object59, "MapGeo_Instance_58");
            AddModel60(object60, "MapGeo_Instance_59");
            AddModel61(object61, "MapGeo_Instance_60");
            AddModel62(object62, "MapGeo_Instance_61");
            AddModel63(object63, "MapGeo_Instance_62");
            AddModel64(object64, "MapGeo_Instance_63");
            AddModel65(object65, "MapGeo_Instance_64");
            AddModel66(object66, "MapGeo_Instance_65");
           // AddModel67(object67, "MapGeo_Instance_66");
            AddModel68(object68, "MapGeo_Instance_67");
            //AddModel69(object69, "MapGeo_Instance_68");
            AddModel70(object70, "MapGeo_Instance_69");
            AddModel71(object71, "MapGeo_Instance_70");
          //  AddModel72(object72, "MapGeo_Instance_71");
            AddModel73(object73, "MapGeo_Instance_72");
            AddModel74(object74, "MapGeo_Instance_73");
            AddModel75(object75, "MapGeo_Instance_74");
            AddModel76(object76, "MapGeo_Instance_75");
           // AddModel77(object77, "MapGeo_Instance_76");
            AddModel78(object78, "MapGeo_Instance_77");
            AddModel79(object79, "MapGeo_Instance_78");
           // AddModel80(object80, "MapGeo_Instance_79");
            AddModel81(object81, "MapGeo_Instance_80");
            AddModel82(object82, "MapGeo_Instance_81");
            AddModel83(object83, "MapGeo_Instance_82");
            AddModel84(object84, "MapGeo_Instance_83");
            AddModel85(object85, "MapGeo_Instance_84");
            AddModel86(object86, "MapGeo_Instance_85");

            //BakedTerrain
            
            AddModel87(object87, "MapGeo_Instance_86");
            AddModel88(object88, "MapGeo_Instance_87");
            AddModel89(object89, "MapGeo_Instance_88");
            AddModel90(object90, "MapGeo_Instance_89");
            AddModel91(object91, "MapGeo_Instance_90");
            AddModel92(object92, "MapGeo_Instance_91");
            AddModel93(object93, "MapGeo_Instance_92");
            AddModel94(object94, "MapGeo_Instance_93");
            AddModel95(object95, "MapGeo_Instance_94");
            AddModel96(object96, "MapGeo_Instance_95");
            AddModel97(object97, "MapGeo_Instance_96");
            AddModel98(object98, "MapGeo_Instance_97");
            AddModel99(object99, "MapGeo_Instance_98");
            AddModel100(object100, "MapGeo_Instance_99");
            AddModel101(object101, "MapGeo_Instance_100");
            AddModel102(object102, "MapGeo_Instance_101");
            AddModel103(object103, "MapGeo_Instance_102");
            AddModel104(object104, "MapGeo_Instance_103");
            AddModel105(object105, "MapGeo_Instance_104");
            AddModel106(object106, "MapGeo_Instance_105");
            AddModel107(object107, "MapGeo_Instance_106");
            AddModel108(object108, "MapGeo_Instance_107");
            AddModel109(object109, "MapGeo_Instance_108");
            AddModel110(object110, "MapGeo_Instance_109");
            AddModel111(object111, "MapGeo_Instance_110");
            AddModel112(object112, "MapGeo_Instance_111");
            AddModel113(object113, "MapGeo_Instance_112");
            AddModel114(object114, "MapGeo_Instance_113");
            AddModel115(object115, "MapGeo_Instance_114");
            AddModel116(object116, "MapGeo_Instance_115");
            AddModel117(object117, "MapGeo_Instance_116");
            AddModel118(object118, "MapGeo_Instance_117");
            AddModel119(object119, "MapGeo_Instance_118");
            AddModel120(object120, "MapGeo_Instance_119");
            AddModel121(object121, "MapGeo_Instance_120");
            AddModel122(object122, "MapGeo_Instance_121");

            //Write the new Mapgeo File. Current Version is 11
            mgeo.Write(@"K:\Riot Games\LeagueSkins\OldSummonersRiftRemastered2\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo", 11);

            //Layer 1 (Base Layer)
            void AddModel(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel3(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel4(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel5(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel6(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel7(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel8(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel9(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel10(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel11(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                
                mgeo.AddModel(object3);
            }
            void AddModel12(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel13(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel14(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/SRX/Materials/Default/Decal", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel15(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            //void AddModel16(OBJFile obj, string name)
            //{
            //    (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
            //    MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
            //    MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
            //    mgeo.AddModel(object3);
            //}
            void AddModel17(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel18(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel19(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel20(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel21(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel22(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel23(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel24(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel25(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel26(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel27(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel28(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel29(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel30(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel31(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel32(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel33(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel34(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel35(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel36(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel37(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel38(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel39(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel40(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel41(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel42(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel43(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel44(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel45(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel46(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel47(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel48(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel49(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            //void AddModel50(OBJFile obj, string name)
            //{
            //    (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
            //    MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
            //    MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
            //    mgeo.AddModel(object2);
            //}
            void AddModel51(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel52(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel53(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel54(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel55(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel56(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel57(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel58(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel59(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel60(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel61(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel62(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel63(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel64(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel65(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel66(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            //void AddModel67(OBJFile obj, string name)
            //{
            //    (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
            //    MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
            //    MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
            //    mgeo.AddModel(object2);
            //}
            void AddModel68(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel69(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel70(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel71(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel72(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel73(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel74(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel75(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel76(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel77(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel78(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel79(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel80(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel81(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel82(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel83(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room83", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel84(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel85(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel86(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }

            //Terrain
            void AddModel87(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel88(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel89(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel90(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel91(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel92(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel93(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel94(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel95(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel96(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel97(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel98(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel99(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel100(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel101(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel102(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel103(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel104(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel105(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel106(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel107(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel108(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel109(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel110(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel111(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel112(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel113(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel114(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel115(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel116(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel117(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel118(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel119(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel120(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel121(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel122(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/old_rift_baked36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }


            
            //Layer 2 = Fire (Infernal)
            //Layer 3 = Earth (Mountain)
            //Layer 4 = Water (Ocean)
            //Layer 5 = Wind (Cloud)

        }

        static void OldRift()
        {
        MapGeometry mgeo = new MapGeometry(@"K:\Riot Games\LeagueofLegendsRAW\LeagueofLegendsRAW\Maps\Shipping\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo");
        
        mgeo.Models.Clear();

            //Add Models
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Terrain

OBJFile terrain1 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain1.obj");
OBJFile terrain2 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain2.obj");
OBJFile terrain3 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain3.obj");
OBJFile terrain4 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain4.obj");
OBJFile terrain5 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain5.obj");
OBJFile terrain6 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain6.obj");
OBJFile terrain7 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain7.obj");
OBJFile terrain8 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain8.obj");
OBJFile terrain9 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain9.obj");
OBJFile terrain10 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain10.obj");
OBJFile terrain11 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain11.obj");
OBJFile terrain12 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain12.obj");
OBJFile terrain13 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain13.obj");
OBJFile terrain14 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain14.obj");
OBJFile terrain15 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain15.obj");
OBJFile terrain16 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain16.obj");
OBJFile terrain17 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain17.obj");
OBJFile terrain18 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain18.obj");
OBJFile terrain19 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain19.obj");
OBJFile terrain20 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain20.obj");
OBJFile terrain21 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain21.obj");
OBJFile terrain22 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain22.obj");
OBJFile terrain23 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain23.obj");
OBJFile terrain24 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain24.obj");
OBJFile terrain25 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain25.obj");
OBJFile terrain26 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain26.obj");
OBJFile terrain27 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain27.obj");
OBJFile terrain28 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain28.obj");
OBJFile terrain29 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain29.obj");
OBJFile terrain30 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain30.obj");
OBJFile terrain31 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain31.obj");
OBJFile terrain32 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain32.obj");
OBJFile terrain33 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain33.obj");
OBJFile terrain34 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain34.obj");
OBJFile terrain35 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain35.obj");
OBJFile terrain36 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\terrain36.obj");

        //Decals
OBJFile decal1 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room3.obj");
OBJFile decal2 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room4.obj"); //Disabled because of mesh issues
OBJFile decal3 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room14.obj");
OBJFile decal4 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room18.obj");
OBJFile decal5 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room26.obj");
OBJFile decal6 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room31.obj");
OBJFile decal7 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room35.obj");
OBJFile decal8 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room43.obj");
OBJFile decal9 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room46.obj");
OBJFile decal10 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room47.obj");
OBJFile decal11 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room48.obj");
OBJFile decal12 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room53.obj");
OBJFile decal13 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room55.obj");
OBJFile decal14 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room56.obj");
OBJFile decal15 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room57.obj");
OBJFile decal16 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room69.obj");
OBJFile decal17 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room72.obj");
OBJFile decal18 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room77.obj");
OBJFile decal19 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room80.obj");

        //Models
OBJFile model1 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room1.obj");
OBJFile model2 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room2.obj");
OBJFile model3 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room5.obj");
OBJFile model4 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room6.obj");
OBJFile model5 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room7.obj");
OBJFile model6 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room8.obj");
OBJFile model7 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room9.obj");
OBJFile model8 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room10.obj");
OBJFile model9 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room11.obj");
OBJFile model10 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room12.obj");
OBJFile model11 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room13.obj");
OBJFile model12 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room15.obj");
OBJFile model13 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room17.obj");
OBJFile model14 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room19.obj");
OBJFile model15 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room20.obj");
OBJFile model16 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room21.obj");
OBJFile model17 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room22.obj");
OBJFile model18 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room23.obj");
OBJFile model19 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room24.obj");
OBJFile model20 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room25.obj");
OBJFile model21 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room27.obj");
OBJFile model22 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room28.obj");
OBJFile model23 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room29.obj");
OBJFile model24 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room30.obj");
OBJFile model25 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room32.obj");
OBJFile model26 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room33.obj");
OBJFile model27 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room34.obj");
OBJFile model28 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room36.obj");
OBJFile model29 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room37.obj");
OBJFile model30 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room38.obj");
OBJFile model31 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room39.obj");
OBJFile model32 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room40.obj");
OBJFile model33 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room41.obj");
OBJFile model34 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room42.obj");
OBJFile model35 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room44.obj");
OBJFile model36 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room45.obj");
OBJFile model37 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room49.obj");
OBJFile model38 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room51.obj");
OBJFile model39 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room52.obj");
OBJFile model40 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room54.obj");
OBJFile model41 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room58.obj");
OBJFile model42 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room59.obj");
OBJFile model43 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room60.obj");
OBJFile model44 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room61.obj");
OBJFile model45 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room62.obj");
OBJFile model46 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room63.obj");
OBJFile model47 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room64.obj");
OBJFile model48 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room65.obj");
OBJFile model49 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room66.obj");
OBJFile model50 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room68.obj");
OBJFile model51 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room70.obj");
OBJFile model52 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room71.obj");
OBJFile model53 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room73.obj");
OBJFile model54 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room74.obj");
OBJFile model55 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room75.obj");
OBJFile model56 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room76.obj");
OBJFile model57 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room78.obj");
OBJFile model58 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room79.obj");
OBJFile model59 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room81.obj");
OBJFile model60 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room82.obj");
OBJFile model61 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room83.obj");
OBJFile model62 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room84.obj");
OBJFile model63 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room85.obj");
OBJFile model64 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Models\room86.obj");
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Terrain
            AddTerrain1(terrain1, "terrain1");
            AddTerrain2(terrain2, "terrain2");
            AddTerrain3(terrain3, "terrain3");
            AddTerrain4(terrain4, "terrain4");
            AddTerrain5(terrain5, "terrain5");
            AddTerrain6(terrain6, "terrain6");
            AddTerrain7(terrain7, "terrain7");
            AddTerrain8(terrain8, "terrain8");
            AddTerrain9(terrain9, "terrain9");
            AddTerrain10(terrain10, "terrain10");
            AddTerrain11(terrain11, "terrain11");
            AddTerrain12(terrain12, "terrain12");
            AddTerrain13(terrain13, "terrain13");
            AddTerrain14(terrain14, "terrain14");
            AddTerrain15(terrain15, "terrain15");
            AddTerrain16(terrain16, "terrain16");
            AddTerrain17(terrain17, "terrain17");
            AddTerrain18(terrain18, "terrain18");
            AddTerrain19(terrain19, "terrain19");
            AddTerrain20(terrain20, "terrain20");
            AddTerrain21(terrain21, "terrain21");
            AddTerrain22(terrain22, "terrain22");
            AddTerrain23(terrain23, "terrain23");
            AddTerrain24(terrain24, "terrain24");
            AddTerrain25(terrain25, "terrain25");
            AddTerrain26(terrain26, "terrain26");
            AddTerrain27(terrain27, "terrain27");
            AddTerrain28(terrain28, "terrain28");
            AddTerrain29(terrain29, "terrain29");
            AddTerrain30(terrain30, "terrain30");
            AddTerrain31(terrain31, "terrain31");
            AddTerrain32(terrain32, "terrain32");
            AddTerrain33(terrain33, "terrain33");
            AddTerrain34(terrain34, "terrain34");
            AddTerrain35(terrain35, "terrain35");
            AddTerrain36(terrain36, "terrain36");





        //Decals
            AddDecal1(decal1, "decal1");
            AddDecal2(decal2, "decal2");
            AddDecal3(decal3, "decal3");
            AddDecal4(decal4, "decal4");
            AddDecal5(decal5, "decal5");
            AddDecal6(decal6, "decal6");
            AddDecal7(decal7, "decal7");
            AddDecal8(decal8, "decal8");
            AddDecal9(decal9, "decal9");
            AddDecal10(decal10, "decal10");
            AddDecal11(decal11, "decal11");
            AddDecal12(decal12, "decal12");
            AddDecal13(decal13, "decal13");
            AddDecal14(decal14, "decal14");
            AddDecal15(decal15, "decal15");
            AddDecal16(decal16, "decal16");
            AddDecal17(decal17, "decal17");
            AddDecal18(decal18, "decal18");
            AddDecal19(decal19, "decal19");

            //Models
            AddModel1(model1, "mesh1");
            AddModel2(model2, "mesh2");
            AddModel3(model3, "mesh3");
            AddModel4(model4, "mesh4"); //Bugged
            AddModel5(model5, "mesh5"); 
            AddModel6(model6, "mesh6");
            AddModel7(model7, "mesh7");
            AddModel8(model8, "mesh8");
            AddModel9(model9, "mesh9");
            AddModel10(model10, "mesh10");
            AddModel11(model11, "mesh11");
            AddModel12(model12, "mesh12");
            AddModel13(model13, "mesh13");
            AddModel14(model14, "mesh14");
            AddModel15(model15, "mesh15");
            AddModel16(model16, "mesh16");
            AddModel17(model17, "mesh17");
            AddModel18(model18, "mesh18");
            AddModel19(model19, "mesh19");
            AddModel20(model20, "mesh20");

            AddModel21(model21, "mesh21");
            AddModel22(model22, "mesh22");
            AddModel23(model23, "mesh23");
            AddModel24(model24, "mesh24");
            AddModel25(model25, "mesh25");
            AddModel26(model26, "mesh26");
            AddModel27(model27, "mesh27");
            AddModel28(model28, "mesh28");
            AddModel29(model29, "mesh29");
            AddModel30(model30, "mesh30");
            AddModel31(model31, "mesh31");
            AddModel32(model32, "mesh32");
            AddModel33(model33, "mesh33");
            AddModel34(model34, "mesh34"); //Bugged
            AddModel35(model35, "mesh35");
            AddModel36(model36, "mesh36");
            AddModel37(model37, "mesh37");
            AddModel38(model38, "mesh38");
            AddModel39(model39, "mesh39");
            AddModel40(model40, "mesh40");
            AddModel41(model41, "mesh41");
            AddModel42(model42, "mesh42");
            AddModel43(model43, "mesh43");
            AddModel44(model44, "mesh44");
            AddModel45(model45, "mesh45");
            AddModel46(model46, "mesh46");
            AddModel47(model47, "mesh47");
            AddModel48(model48, "mesh48");
            AddModel49(model49, "mesh49");
            AddModel50(model50, "mesh50");
            AddModel51(model51, "mesh51");
            AddModel52(model52, "mesh52");
            AddModel53(model53, "mesh53");
            AddModel54(model54, "mesh54");
            AddModel55(model55, "mesh55");
            AddModel56(model56, "mesh56");
            AddModel57(model57, "mesh57");
            AddModel58(model58, "mesh58");
            AddModel59(model59, "mesh59");
            AddModel60(model60, "mesh60");
            AddModel61(model61, "mesh61");
            AddModel62(model62, "mesh62");
            AddModel63(model63, "mesh63");
            AddModel64(model64, "mesh64");

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

            //Write the new Mapgeo File. Current Version is 11
            mgeo.Write(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo", 11);
            mgeo.Write(@"K:\Riot Games\LeagueSkins\OldRift\OldRift\Map11\data\maps\mapgeometry\sr\worlds.mapgeo", 11);

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            
            void AddTerrain1(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                
                mgeo.AddModel(terrain);
            }
            void AddTerrain2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain3(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain4(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain5(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain6(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain7(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain8(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain9(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain10(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain11(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain12(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain13(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain14(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain15(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain16(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.Color = new Color(1, 0, 0, 1); //Method to change the color on the mesh
                terrain.SeparatePointLight = new Vector3(1, 1, 1);
                terrain.Color = new Color(1.0f, 0.0f, 0.0f);
                mgeo.AddModel(terrain);
            }
            void AddTerrain17(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                
                mgeo.AddModel(terrain);
            }
            void AddTerrain18(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain19(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain20(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain21(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain22(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain23(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain24(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain25(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain26(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain27(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain28(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain29(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain30(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
             void AddTerrain31(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain32(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain33(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain34(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain35(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }
            void AddTerrain36(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Terrain36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel terrain = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                terrain.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(terrain);
            }

//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            void AddDecal1(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal3(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal4(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal5(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal6(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal7(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal8(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal9(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal10(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal11(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal12(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal13(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal14(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal15(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal16(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal17(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal18(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddDecal19(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Decal19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            void AddModel1(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel3(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel4(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel5(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel6(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel7(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel8(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel9(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel10(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel11(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel12(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel13(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel14(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel15(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel16(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel17(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel18(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel19(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel20(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel21(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel22(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel23(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel24(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel25(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel26(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel27(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel28(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel29(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel30(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel31(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel32(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel33(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel34(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel35(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel36(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel37(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel38(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel39(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel40(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel41(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel42(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel43(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel44(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel45(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel46(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel47(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel48(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel49(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel50(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel51(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel52(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel53(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel54(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel55(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel56(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel57(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel58(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel59(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel60(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel61(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel62(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel63(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
            void AddModel64(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/OldRift/Materials/Default/Model64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }

        }
        
        static void Sandbox()
        {
        MapGeometry mgeo = new MapGeometry(@"K:\Riot Games\LeagueofLegendsRAW\LeagueofLegendsRAW\Maps\Shipping\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo");
        mgeo.Models.Clear();

        OBJFile sandbox = new OBJFile(@"K:\Riot Games\LeagueSkins\DefaultTestMap\Models\testmap.obj");
        OBJFile decal = new OBJFile(@"K:\Riot Games\LeagueSkins\DefaultTestMap\Models\decal.obj");

        AddModel(sandbox, "MapGeo_Instance_0");
        AddModel2(decal, "MapGeo_Instance_1");

        //Write the new Mapgeo File. Current Version is 11
            mgeo.Write(@"K:\Riot Games\LeagueSkins\DefaultTestMap\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo", 11);

            
            void AddModel(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/SRX/Materials/Default/Sandbox", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel sandbox = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                sandbox.SeparatePointLight = new Vector3(1, 1, 1); //Unknown what it does.
                mgeo.AddModel(sandbox);
            }
            void AddModel2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/SRX/Materials/Default/Decal", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel decal = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(decal);
            }
        }

        static void HalloweenRift()  
        {
            MapGeometry mgeo = new MapGeometry(@"K:\Riot Games\LeagueofLegendsRAW\LeagueofLegendsRAW\Maps\Shipping\Map11\data\maps\mapgeometry\sr\base_srx.mapgeo");
            mgeo.Models.Clear();

            //ModelsForOldRift K:\Riot Games\LeagueSkins\OldHalloweenRift\Models

            //Layer 0 (Base Layer)
            OBJFile object1 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room1.obj");
            OBJFile object2 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room2.obj");
            OBJFile object3 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room3.obj");
            OBJFile object4 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room4.obj"); 
            OBJFile object5 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room5.obj");
            OBJFile object6 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room6.obj");
            OBJFile object7 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room7.obj");
            OBJFile object8 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room8.obj");
            OBJFile object9 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room9.obj");
            OBJFile object10 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room10.obj");
            OBJFile object11 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room11.obj");
            OBJFile object12 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room12.obj");
            OBJFile object13 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room13.obj");
            OBJFile object14 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room14.obj"); 
            OBJFile object15 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room15.obj");
            OBJFile object16 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room16.obj"); 
            OBJFile object17 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room17.obj");
            OBJFile object18 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room18.obj"); 
            OBJFile object19 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room19.obj");
            OBJFile object20 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room20.obj");
            OBJFile object21 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room21.obj");
            OBJFile object22 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room22.obj");
            OBJFile object23 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room23.obj");
            OBJFile object24 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room24.obj");
            OBJFile object25 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room25.obj");
            OBJFile object26 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room26.obj"); 
            OBJFile object27 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room27.obj");
            OBJFile object28 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room28.obj");
            OBJFile object29 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room29.obj");
            OBJFile object30 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room30.obj");
            OBJFile object31 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room31.obj"); 
            OBJFile object32 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room32.obj");
            OBJFile object33 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room33.obj");
            OBJFile object34 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room34.obj");
            OBJFile object35 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room35.obj"); 
            OBJFile object36 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room36.obj");
            OBJFile object37 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room37.obj");
            OBJFile object38 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room38.obj");
            OBJFile object39 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room39.obj");
            OBJFile object40 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room40.obj");
            OBJFile object41 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room41.obj");
            OBJFile object42 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room42.obj");
            OBJFile object43 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room43.obj"); 
            OBJFile object44 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room44.obj");
            OBJFile object45 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room45.obj");
            OBJFile object46 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room46.obj"); 
            OBJFile object47 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room47.obj"); 
            OBJFile object48 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room48.obj"); 
            OBJFile object49 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room49.obj");
            OBJFile object50 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room50.obj"); 
            OBJFile object51 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room51.obj");
            OBJFile object52 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room52.obj");
            OBJFile object53 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room53.obj"); 
            OBJFile object54 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room54.obj");
            OBJFile object55 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room55.obj"); 
            OBJFile object56 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room56.obj"); 
            OBJFile object57 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room57.obj"); 
            OBJFile object58 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room58.obj");
            OBJFile object59 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room59.obj");
            OBJFile object60 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room60.obj");
            OBJFile object61 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room61.obj");
            OBJFile object62 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room62.obj");
            OBJFile object63 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room63.obj"); 
            OBJFile object64 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room64.obj");
            OBJFile object65 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room65.obj");
            OBJFile object66 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room66.obj");
            OBJFile object67 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room67.obj"); 
            OBJFile object68 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room68.obj");
            OBJFile object69 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room69.obj"); 
            OBJFile object70 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room70.obj");
            OBJFile object71 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room71.obj");
            OBJFile object72 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room72.obj"); 
            OBJFile object73 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room73.obj");
            OBJFile object74 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room74.obj");
            OBJFile object75 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room75.obj");
            OBJFile object76 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room76.obj");
            OBJFile object77 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room77.obj"); 
            OBJFile object78 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room78.obj");
            OBJFile object79 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room79.obj");
            OBJFile object80 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room80.obj"); 
            OBJFile object81 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room81.obj");
            OBJFile object82 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room82.obj");
            //OBJFile object83 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room83.obj");
            OBJFile object84 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room84.obj");
            OBJFile object85 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room85.obj");
            OBJFile object86 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room86.obj");
            OBJFile object87 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room87.obj");
            OBJFile object88 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room88.obj");
            OBJFile object89 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room89.obj");
            OBJFile object90 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room90.obj");
            OBJFile object91 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room91.obj");
            OBJFile object92 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room92.obj");
            OBJFile object93 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room93.obj");
            OBJFile object94 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room94.obj");
            OBJFile object95 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room95.obj");
            OBJFile object96 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room96.obj");
            OBJFile object97 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room97.obj");
            OBJFile object98 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room98.obj");
            OBJFile object99 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room99.obj");
            OBJFile object100 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room100.obj");
            OBJFile object101 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room101.obj");
            OBJFile object102 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room102.obj");
            OBJFile object103 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room103.obj");
            OBJFile object104 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room104.obj");
            OBJFile object105 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room105.obj");
            OBJFile object106 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room106.obj");
            OBJFile object107 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room107.obj");
            OBJFile object108 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room108.obj");
            OBJFile object109 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room109.obj");
            OBJFile object110 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room110.obj");
            OBJFile object111 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room111.obj");
            OBJFile object112 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room112.obj");
            OBJFile object113 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room113.obj");
            OBJFile object114 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room114.obj");
            OBJFile object115 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room115.obj");
            OBJFile object116 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room116.obj");
            OBJFile object117 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room117.obj");
            OBJFile object118 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room118.obj");
            OBJFile object119 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room119.obj");
            OBJFile object120 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room120.obj");
            OBJFile object121 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room121.obj");
            OBJFile object122 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room122.obj");
            OBJFile object123 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room123.obj");
            OBJFile object124 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room124.obj");
            OBJFile object125 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room125.obj");
            OBJFile object126 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room126.obj"); 
            OBJFile object127 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room127.obj");
            OBJFile object128 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room128.obj");
            OBJFile object129 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room129.obj");
            OBJFile object130 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room130.obj");
            OBJFile object131 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room131.obj"); 
            OBJFile object132 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room132.obj");
            OBJFile object133 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room133.obj");
            OBJFile object134 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room134.obj");
            OBJFile object135 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room135.obj"); 
            OBJFile object136 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room136.obj");
            OBJFile object137 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room137.obj");
            OBJFile object138 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room138.obj");
            OBJFile object139 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room139.obj");
            OBJFile object140 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room140.obj");
            OBJFile object141 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room141.obj");
            OBJFile object142 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room142.obj");
            OBJFile object143 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room143.obj"); 
            OBJFile object144 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room144.obj");
            OBJFile object145 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room145.obj");
            OBJFile object146 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room146.obj"); 
            OBJFile object147 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room147.obj"); 
            OBJFile object148 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room148.obj"); 
            OBJFile object149 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room149.obj");
            OBJFile object150 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room150.obj"); 
            OBJFile object151 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room151.obj");
            OBJFile object152 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room152.obj");
            OBJFile object153 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room153.obj"); 
            OBJFile object154 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room154.obj");
            OBJFile object155 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room155.obj"); 
            OBJFile object156 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room156.obj"); 
            OBJFile object157 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room157.obj");

            //Layer 1 (Fire or Infernal)
            OBJFile object158 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room158.obj");
            OBJFile object159 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room159.obj");
            OBJFile object160 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room160.obj");
            OBJFile object161 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room161.obj"); 
            OBJFile object162 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room162.obj");
            OBJFile object163 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room163.obj");
            OBJFile object164 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room164.obj");
            OBJFile object165 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room165.obj");
            OBJFile object166 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room166.obj");
            OBJFile object167 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room167.obj");
            OBJFile object168 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room168.obj");
            OBJFile object169 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room169.obj");
            OBJFile object170 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room170.obj");
            OBJFile object171 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room171.obj"); 
            OBJFile object172 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room172.obj");
            OBJFile object173 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room173.obj"); 
            OBJFile object174 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room174.obj");
            OBJFile object175 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room175.obj"); 
            OBJFile object176 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room176.obj");
            OBJFile object177 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room177.obj");
            OBJFile object178 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room178.obj");
            OBJFile object179 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room179.obj");
            OBJFile object180 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room180.obj");
            OBJFile object181 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room181.obj");
            OBJFile object182 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room182.obj");
            OBJFile object183 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room183.obj"); 
            OBJFile object184 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room184.obj");
            OBJFile object185 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room185.obj");
            OBJFile object186 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room186.obj");
            OBJFile object187 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room187.obj");
            OBJFile object188 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room188.obj"); 
            OBJFile object189 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room189.obj");
            OBJFile object190 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room190.obj");
            OBJFile object191 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room191.obj");
            OBJFile object192 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room192.obj"); 
            OBJFile object193 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room193.obj");
            OBJFile object194 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room194.obj");
            OBJFile object195 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room195.obj");
            OBJFile object196 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room196.obj");
            OBJFile object197 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room197.obj");
            OBJFile object198 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room198.obj");
            OBJFile object199 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room199.obj");
            OBJFile object200 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room200.obj"); 
            OBJFile object201 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room201.obj");
            OBJFile object202 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room202.obj");
            OBJFile object203 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room203.obj"); 
            OBJFile object204 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room204.obj"); 
            OBJFile object205 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room205.obj"); 
            OBJFile object206 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room206.obj");
            OBJFile object207 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room207.obj"); 
            OBJFile object208 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room208.obj");
            OBJFile object209 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room209.obj");
            OBJFile object210 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room210.obj"); 
            OBJFile object211 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room211.obj");
            OBJFile object212 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room212.obj"); 
            OBJFile object213 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room213.obj"); 
            OBJFile object214 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room214.obj"); 
            OBJFile object215 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room215.obj");
            OBJFile object216 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room216.obj");
            OBJFile object217 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room217.obj");
            OBJFile object218 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room218.obj");
            OBJFile object219 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room219.obj");
            OBJFile object220 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room220.obj"); 
            OBJFile object221 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room221.obj");
            OBJFile object222 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room222.obj");
            OBJFile object223 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room223.obj");
            OBJFile object224 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room224.obj"); 
            OBJFile object225 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room225.obj");
            OBJFile object226 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room226.obj"); 
            OBJFile object227 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room227.obj");
            OBJFile object228 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room228.obj");
            OBJFile object229 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room229.obj"); 
            OBJFile object230 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room230.obj");
            OBJFile object231 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room231.obj");
            OBJFile object232 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room232.obj");
            OBJFile object233 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room233.obj");
            OBJFile object234 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room234.obj"); 
            OBJFile object235 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room235.obj");
            OBJFile object236 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room236.obj");
            OBJFile object237 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room237.obj"); 
            OBJFile object238 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room238.obj");
            OBJFile object239 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room239.obj");
            OBJFile object240 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room240.obj");
            OBJFile object241 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room241.obj");
            OBJFile object242 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room242.obj");
            OBJFile object243 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room243.obj");
            OBJFile object244 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room244.obj");
            OBJFile object245 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room245.obj");
            OBJFile object246 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room246.obj");
            OBJFile object247 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room247.obj");
            OBJFile object248 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room248.obj");
            OBJFile object249 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room249.obj");
            OBJFile object250 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room250.obj");
            OBJFile object251 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room251.obj");
            OBJFile object252 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room252.obj");
            OBJFile object253 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room253.obj");
            OBJFile object254 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room254.obj");
            OBJFile object255 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room255.obj");
            OBJFile object256 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room256.obj");
            OBJFile object257 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room257.obj");
            OBJFile object258 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room258.obj");
            OBJFile object259 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room259.obj");
            OBJFile object260 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room260.obj");
            OBJFile object261 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room261.obj");
            OBJFile object262 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room262.obj");
            OBJFile object263 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room263.obj");
            OBJFile object264 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room264.obj");
            OBJFile object265 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room265.obj");
            OBJFile object266 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room266.obj");
            OBJFile object267 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room267.obj");
            OBJFile object268 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room268.obj");
            OBJFile object269 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room269.obj");
            OBJFile object270 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room270.obj");
            OBJFile object271 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room271.obj");
            OBJFile object272 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room272.obj");
            OBJFile object273 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room273.obj");
            OBJFile object274 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room274.obj");
            OBJFile object275 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room275.obj");
            OBJFile object276 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room276.obj");
            OBJFile object277 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room277.obj");
            OBJFile object278 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room278.obj");
            OBJFile object279 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room279.obj");
            OBJFile object280 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room280.obj");
            OBJFile object281 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room281.obj");
            OBJFile object282 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room282.obj"); 
            OBJFile object283 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room283.obj");
            OBJFile object284 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room284.obj");
            OBJFile object285 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room285.obj");
            OBJFile object286 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room286.obj");
            OBJFile object287 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room287.obj"); 
            OBJFile object288 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room288.obj");
            OBJFile object289 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room289.obj");
            OBJFile object290 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room290.obj");
            OBJFile object291 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room291.obj"); 
            OBJFile object292 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room292.obj");
            OBJFile object293 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room293.obj");
            OBJFile object294 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room294.obj");
            OBJFile object295 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room295.obj");
            OBJFile object296 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room296.obj");
            OBJFile object297 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room297.obj");
            OBJFile object298 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room298.obj");
            OBJFile object299 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room299.obj"); 
            OBJFile object300 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room300.obj");
            OBJFile object301 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room301.obj");
            OBJFile object302 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room302.obj"); 
            OBJFile object303 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room303.obj"); 
            OBJFile object304 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room304.obj"); 
            OBJFile object305 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room305.obj");
            OBJFile object306 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room306.obj"); 
            OBJFile object307 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room307.obj");
            OBJFile object308 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room308.obj");
            OBJFile object309 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room309.obj"); 
            OBJFile object310 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room310.obj");
            OBJFile object311 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room311.obj"); 
            OBJFile object312 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room312.obj"); 
            OBJFile object313 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room313.obj");

            //Layer 2 (Earth or Mountain)
            OBJFile object314 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room314.obj");
            OBJFile object315 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room315.obj");
            OBJFile object316 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room316.obj");
            OBJFile object317 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room317.obj"); 
            OBJFile object318 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room318.obj");
            OBJFile object319 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room319.obj");
            OBJFile object320 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room320.obj");
            OBJFile object321 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room321.obj");
            OBJFile object322 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room322.obj");
            OBJFile object323 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room323.obj");
            OBJFile object324 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room324.obj");
            OBJFile object325 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room325.obj");
            OBJFile object326 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room326.obj");
            OBJFile object327 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room327.obj"); 
            OBJFile object328 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room328.obj");
            OBJFile object329 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room329.obj"); 
            OBJFile object330 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room330.obj");
            OBJFile object331 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room331.obj"); 
            OBJFile object332 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room332.obj");
            OBJFile object333 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room333.obj");
            OBJFile object334 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room334.obj");
            OBJFile object335 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room335.obj");
            OBJFile object336 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room336.obj");
            OBJFile object337 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room337.obj");
            OBJFile object338 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room338.obj");
            OBJFile object339 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room339.obj"); 
            OBJFile object340 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room340.obj");
            OBJFile object341 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room341.obj");
            OBJFile object342 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room342.obj");
            OBJFile object343 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room343.obj");
            OBJFile object344 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room344.obj"); 
            OBJFile object345 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room345.obj");
            OBJFile object346 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room346.obj");
            OBJFile object347 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room347.obj");
            OBJFile object348 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room348.obj"); 
            OBJFile object349 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room349.obj");
            OBJFile object350 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room350.obj");
            OBJFile object351 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room351.obj");
            OBJFile object352 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room352.obj");
            OBJFile object353 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room353.obj");
            OBJFile object354 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room354.obj");
            OBJFile object355 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room355.obj");
            OBJFile object356 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room356.obj"); 
            OBJFile object357 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room357.obj");
            OBJFile object358 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room358.obj");
            OBJFile object359 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room359.obj"); 
            OBJFile object360 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room360.obj"); 
            OBJFile object361 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room361.obj"); 
            OBJFile object362 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room362.obj");
            OBJFile object363 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room363.obj"); 
            OBJFile object364 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room364.obj");
            OBJFile object365 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room365.obj");
            OBJFile object366 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room366.obj"); 
            OBJFile object367 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room367.obj");
            OBJFile object368 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room368.obj"); 
            OBJFile object369 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room369.obj"); 
            OBJFile object370 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room370.obj"); 
            OBJFile object371 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room371.obj");
            OBJFile object372 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room372.obj");
            OBJFile object373 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room373.obj");
            OBJFile object374 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room374.obj");
            OBJFile object375 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room375.obj");
            OBJFile object376 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room376.obj"); 
            OBJFile object377 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room377.obj");
            OBJFile object378 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room378.obj");
            OBJFile object379 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room379.obj");
            OBJFile object380 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room380.obj"); 
            OBJFile object381 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room381.obj");
            OBJFile object382 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room382.obj"); 
            OBJFile object383 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room383.obj");
            OBJFile object384 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room384.obj");
            OBJFile object385 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room385.obj"); 
            OBJFile object386 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room386.obj");
            OBJFile object387 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room387.obj");
            OBJFile object388 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room388.obj");
            OBJFile object389 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room389.obj");
            OBJFile object390 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room390.obj"); 
            OBJFile object391 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room391.obj");
            OBJFile object392 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room392.obj");
            OBJFile object393 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room393.obj"); 
            OBJFile object394 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room394.obj");
            OBJFile object395 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room395.obj");
            OBJFile object396 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room396.obj");
            OBJFile object397 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room397.obj");
            OBJFile object398 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room398.obj");
            OBJFile object399 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room399.obj");
            OBJFile object400 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room400.obj");
            OBJFile object401 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room401.obj");
            OBJFile object402 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room402.obj");
            OBJFile object403 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room403.obj");
            OBJFile object404 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room404.obj");
            OBJFile object405 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room405.obj");
            OBJFile object406 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room406.obj");
            OBJFile object407 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room407.obj");
            OBJFile object408 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room408.obj");
            OBJFile object409 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room409.obj");
            OBJFile object410 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room410.obj");
            OBJFile object411 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room411.obj");
            OBJFile object412 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room412.obj");
            OBJFile object413 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room413.obj");
            OBJFile object414 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room414.obj");
            OBJFile object415 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room415.obj");
            OBJFile object416 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room416.obj");
            OBJFile object417 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room417.obj");
            OBJFile object418 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room418.obj");
            OBJFile object419 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room419.obj");
            OBJFile object420 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room420.obj");
            OBJFile object421 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room421.obj");
            OBJFile object422 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room422.obj");
            OBJFile object423 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room423.obj");
            OBJFile object424 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room424.obj");
            OBJFile object425 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room425.obj");
            OBJFile object426 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room426.obj");
            OBJFile object427 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room427.obj");
            OBJFile object428 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room428.obj");
            OBJFile object429 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room429.obj");
            OBJFile object430 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room430.obj");
            OBJFile object431 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room431.obj");
            OBJFile object432 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room432.obj");
            OBJFile object433 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room433.obj");
            OBJFile object434 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room434.obj");
            OBJFile object435 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room435.obj");
            OBJFile object436 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room436.obj");
            OBJFile object437 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room437.obj");
            OBJFile object438 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room438.obj"); 
            OBJFile object439 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room439.obj");
            OBJFile object440 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room440.obj");
            OBJFile object441 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room441.obj");
            OBJFile object442 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room442.obj");
            OBJFile object443 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room443.obj"); 
            OBJFile object444 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room444.obj");
            OBJFile object445 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room445.obj");
            OBJFile object446 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room446.obj");
            OBJFile object447 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room447.obj"); 
            OBJFile object448 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room448.obj");
            OBJFile object449 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room449.obj");
            OBJFile object450 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room450.obj");
            OBJFile object451 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room451.obj");
            OBJFile object452 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room452.obj");
            OBJFile object453 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room453.obj");
            OBJFile object454 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room454.obj");
            OBJFile object455 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room455.obj"); 
            OBJFile object456 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room456.obj");
            OBJFile object457 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room457.obj");
            OBJFile object458 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room458.obj"); 
            OBJFile object459 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room459.obj"); 
            OBJFile object460 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room460.obj"); 
            OBJFile object461 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room461.obj");
            OBJFile object462 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room462.obj"); 
            OBJFile object463 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room463.obj");
            OBJFile object464 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room464.obj");
            OBJFile object465 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room465.obj"); 
            OBJFile object466 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room466.obj");
            OBJFile object467 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room467.obj"); 
            OBJFile object468 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room468.obj"); 
            OBJFile object469 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room469.obj");

            //Layer 3 (Water or Ocean)
            OBJFile object470 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room470.obj");
            OBJFile object471 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room471.obj");
            OBJFile object472 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room472.obj");
            OBJFile object473 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room473.obj"); 
            OBJFile object474 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room474.obj");
            OBJFile object475 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room475.obj");
            OBJFile object476 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room476.obj");
            OBJFile object477 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room477.obj");
            OBJFile object478 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room478.obj");
            OBJFile object479 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room479.obj");
            OBJFile object480 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room480.obj");
            OBJFile object481 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room481.obj");
            OBJFile object482 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room482.obj");
            OBJFile object483 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room483.obj"); 
            OBJFile object484 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room484.obj");
            OBJFile object485 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room485.obj"); 
            OBJFile object486 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room486.obj");
            OBJFile object487 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room487.obj"); 
            OBJFile object488 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room488.obj");
            OBJFile object489 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room489.obj");
            OBJFile object490 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room490.obj");
            OBJFile object491 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room491.obj");
            OBJFile object492 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room492.obj");
            OBJFile object493 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room493.obj");
            OBJFile object494 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room494.obj");
            OBJFile object495 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room495.obj"); 
            OBJFile object496 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room496.obj");
            OBJFile object497 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room497.obj");
            OBJFile object498 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room498.obj");
            OBJFile object499 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room499.obj");
            OBJFile object500 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room500.obj"); 
            OBJFile object501 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room501.obj");
            OBJFile object502 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room502.obj");
            OBJFile object503 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room503.obj");
            OBJFile object504 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room504.obj"); 
            OBJFile object505 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room505.obj");
            OBJFile object506 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room506.obj");
            OBJFile object507 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room507.obj");
            OBJFile object508 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room508.obj");
            OBJFile object509 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room509.obj");
            OBJFile object510 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room510.obj");
            OBJFile object511 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room511.obj");
            OBJFile object512 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room512.obj"); 
            OBJFile object513 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room513.obj");
            OBJFile object514 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room514.obj");
            OBJFile object515 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room515.obj"); 
            OBJFile object516 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room516.obj"); 
            OBJFile object517 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room517.obj"); 
            OBJFile object518 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room518.obj");
            OBJFile object519 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room519.obj"); 
            OBJFile object520 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room520.obj");
            OBJFile object521 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room521.obj");
            OBJFile object522 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room522.obj"); 
            OBJFile object523 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room523.obj");
            OBJFile object524 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room524.obj"); 
            OBJFile object525 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room525.obj"); 
            OBJFile object526 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room526.obj"); 
            OBJFile object527 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room527.obj");
            OBJFile object528 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room528.obj");
            OBJFile object529 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room529.obj");
            OBJFile object530 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room530.obj");
            OBJFile object531 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room531.obj");
            OBJFile object532 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room532.obj"); 
            OBJFile object533 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room533.obj");
            OBJFile object534 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room534.obj");
            OBJFile object535 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room535.obj");
            OBJFile object536 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room536.obj"); 
            OBJFile object537 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room537.obj");
            OBJFile object538 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room538.obj"); 
            OBJFile object539 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room539.obj");
            OBJFile object540 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room540.obj");
            OBJFile object541 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room541.obj"); 
            OBJFile object542 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room542.obj");
            OBJFile object543 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room543.obj");
            OBJFile object544 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room544.obj");
            OBJFile object545 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room545.obj");
            OBJFile object546 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room546.obj"); 
            OBJFile object547 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room547.obj");
            OBJFile object548 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room548.obj");
            OBJFile object549 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room549.obj"); 
            OBJFile object550 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room550.obj");
            OBJFile object551 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room551.obj");
            OBJFile object552 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room552.obj");
            OBJFile object553 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room553.obj");
            OBJFile object554 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room554.obj");
            OBJFile object555 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room555.obj");
            OBJFile object556 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room556.obj");
            OBJFile object557 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room557.obj");
            OBJFile object558 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room558.obj");
            OBJFile object559 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room559.obj");
            OBJFile object560 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room560.obj");
            OBJFile object561 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room561.obj");
            OBJFile object562 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room562.obj");
            OBJFile object563 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room563.obj");
            OBJFile object564 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room564.obj");
            OBJFile object565 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room565.obj");
            OBJFile object566 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room566.obj");
            OBJFile object567 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room567.obj");
            OBJFile object568 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room568.obj");
            OBJFile object569 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room569.obj");
            OBJFile object570 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room570.obj");
            OBJFile object571 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room571.obj");
            OBJFile object572 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room572.obj");
            OBJFile object573 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room573.obj");
            OBJFile object574 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room574.obj");
            OBJFile object575 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room575.obj");
            OBJFile object576 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room576.obj");
            OBJFile object577 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room577.obj");
            OBJFile object578 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room578.obj");
            OBJFile object579 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room579.obj");
            OBJFile object580 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room580.obj");
            OBJFile object581 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room581.obj");
            OBJFile object582 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room582.obj");
            OBJFile object583 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room583.obj");
            OBJFile object584 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room584.obj");
            OBJFile object585 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room585.obj");
            OBJFile object586 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room586.obj");
            OBJFile object587 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room587.obj");
            OBJFile object588 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room588.obj");
            OBJFile object589 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room589.obj");
            OBJFile object590 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room590.obj");
            OBJFile object591 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room591.obj");
            OBJFile object592 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room592.obj");
            OBJFile object593 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room593.obj");
            OBJFile object594 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room594.obj"); 
            OBJFile object595 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room595.obj");
            OBJFile object596 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room596.obj");
            OBJFile object597 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room597.obj");
            OBJFile object598 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room598.obj");
            OBJFile object599 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room599.obj"); 
            OBJFile object600 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room600.obj");
            OBJFile object601 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room601.obj");
            OBJFile object602 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room602.obj");
            OBJFile object603 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room603.obj"); 
            OBJFile object604 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room604.obj");
            OBJFile object605 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room605.obj");
            OBJFile object606 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room606.obj");
            OBJFile object607 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room607.obj");
            OBJFile object608 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room608.obj");
            OBJFile object609 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room609.obj");
            OBJFile object610 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room610.obj");
            OBJFile object611 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room611.obj"); 
            OBJFile object612 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room612.obj");
            OBJFile object613 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room613.obj");
            OBJFile object614 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room614.obj"); 
            OBJFile object615 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room615.obj"); 
            OBJFile object616 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room616.obj"); 
            OBJFile object617 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room617.obj");
            OBJFile object618 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room618.obj"); 
            OBJFile object619 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room619.obj");
            OBJFile object620 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room620.obj");
            OBJFile object621 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room621.obj"); 
            OBJFile object622 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room622.obj");
            OBJFile object623 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room623.obj"); 
            OBJFile object624 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room624.obj"); 
            OBJFile object625 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room625.obj");

            //Layer 4 (Wind or  Cloud)
            OBJFile object626 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room626.obj");
            OBJFile object627 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room627.obj");
            OBJFile object628 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room628.obj");
            OBJFile object629 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room629.obj"); 
            OBJFile object630 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room630.obj");
            OBJFile object631 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room631.obj");
            OBJFile object632 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room632.obj");
            OBJFile object633 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room633.obj");
            OBJFile object634 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room634.obj");
            OBJFile object635 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room635.obj");
            OBJFile object636 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room636.obj");
            OBJFile object637 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room637.obj");
            OBJFile object638 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room638.obj");
            OBJFile object639 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room639.obj"); 
            OBJFile object640 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room640.obj");
            OBJFile object641 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room641.obj"); 
            OBJFile object642 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room642.obj");
            OBJFile object643 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room643.obj"); 
            OBJFile object644 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room644.obj");
            OBJFile object645 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room645.obj");
            OBJFile object646 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room646.obj");
            OBJFile object647 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room647.obj");
            OBJFile object648 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room648.obj");
            OBJFile object649 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room649.obj");
            OBJFile object650 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room650.obj");
            OBJFile object651 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room651.obj"); 
            OBJFile object652 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room652.obj");
            OBJFile object653 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room653.obj");
            OBJFile object654 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room654.obj");
            OBJFile object655 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room655.obj");
            OBJFile object656 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room656.obj"); 
            OBJFile object657 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room657.obj");
            OBJFile object658 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room658.obj");
            OBJFile object659 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room659.obj");
            OBJFile object660 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room660.obj"); 
            OBJFile object661 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room661.obj");
            OBJFile object662 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room662.obj");
            OBJFile object663 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room663.obj");
            OBJFile object664 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room664.obj");
            OBJFile object665 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room665.obj");
            OBJFile object666 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room666.obj");
            OBJFile object667 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room667.obj");
            OBJFile object668 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room668.obj"); 
            OBJFile object669 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room669.obj");
            OBJFile object670 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room670.obj");
            OBJFile object671 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room671.obj"); 
            OBJFile object672 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room672.obj"); 
            OBJFile object673 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room673.obj"); 
            OBJFile object674 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room674.obj");
            OBJFile object675 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room675.obj"); 
            OBJFile object676 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room676.obj");
            OBJFile object677 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room677.obj");
            OBJFile object678 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room678.obj"); 
            OBJFile object679 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room679.obj");
            OBJFile object680 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room680.obj"); 
            OBJFile object681 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room681.obj"); 
            OBJFile object682 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room682.obj"); 
            OBJFile object683 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room683.obj");
            OBJFile object684 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room684.obj");
            OBJFile object685 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room685.obj");
            OBJFile object686 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room686.obj");
            OBJFile object687 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room687.obj");
            OBJFile object688 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room688.obj"); 
            OBJFile object689 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room689.obj");
            OBJFile object690 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room690.obj");
            OBJFile object691 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room691.obj");
            OBJFile object692 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room692.obj"); 
            OBJFile object693 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room693.obj");
            OBJFile object694 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room694.obj"); 
            OBJFile object695 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room695.obj");
            OBJFile object696 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room696.obj");
            OBJFile object697 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room697.obj"); 
            OBJFile object698 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room698.obj");
            OBJFile object699 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room699.obj");
            OBJFile object700 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room700.obj");
            OBJFile object701 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room701.obj");
            OBJFile object702 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room702.obj"); 
            OBJFile object703 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room703.obj");
            OBJFile object704 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room704.obj");
            OBJFile object705 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room705.obj"); 
            OBJFile object706 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room706.obj");
            OBJFile object707 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room707.obj");
            OBJFile object708 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room708.obj");
            OBJFile object709 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room709.obj");
            OBJFile object710 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room710.obj");
            OBJFile object711 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room711.obj");
            OBJFile object712 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room712.obj");
            OBJFile object713 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room713.obj");
            OBJFile object714 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room714.obj");
            OBJFile object715 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room715.obj");
            OBJFile object716 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room716.obj");
            OBJFile object717 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room717.obj");
            OBJFile object718 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room718.obj");
            OBJFile object719 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room719.obj");
            OBJFile object720 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room720.obj");
            OBJFile object721 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room721.obj");
            OBJFile object722 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room722.obj");
            OBJFile object723 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room723.obj");
            OBJFile object724 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room724.obj");
            OBJFile object725 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room725.obj");
            OBJFile object726 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room726.obj");
            OBJFile object727 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room727.obj");
            OBJFile object728 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room728.obj");
            OBJFile object729 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room729.obj");
            OBJFile object730 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room730.obj");
            OBJFile object731 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room731.obj");
            OBJFile object732 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room732.obj");
            OBJFile object733 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room733.obj");
            OBJFile object734 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room734.obj");
            OBJFile object735 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room735.obj");
            OBJFile object736 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room736.obj");
            OBJFile object737 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room737.obj");
            OBJFile object738 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room738.obj");
            OBJFile object739 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room739.obj");
            OBJFile object740 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room740.obj");
            OBJFile object741 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room741.obj");
            OBJFile object742 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room742.obj");
            OBJFile object743 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room743.obj");
            OBJFile object744 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room744.obj");
            OBJFile object745 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room745.obj");
            OBJFile object746 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room746.obj");
            OBJFile object747 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room747.obj");
            OBJFile object748 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room748.obj");
            OBJFile object749 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room749.obj");
            OBJFile object750 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room750.obj"); 
            OBJFile object751 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room751.obj");
            OBJFile object752 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room752.obj");
            OBJFile object753 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room753.obj");
            OBJFile object754 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room754.obj");
            OBJFile object755 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room755.obj"); 
            OBJFile object756 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room756.obj");
            OBJFile object757 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room757.obj");
            OBJFile object758 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room758.obj");
            OBJFile object759 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room759.obj"); 
            OBJFile object760 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room760.obj");
            OBJFile object761 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room761.obj");
            OBJFile object762 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room762.obj");
            OBJFile object763 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room763.obj");
            OBJFile object764 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room764.obj");
            OBJFile object765 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room765.obj");
            OBJFile object766 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room766.obj");
            OBJFile object767 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room767.obj"); 
            OBJFile object768 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room768.obj");
            OBJFile object769 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room769.obj");
            OBJFile object770 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room770.obj"); 
            OBJFile object771 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room771.obj"); 
            OBJFile object772 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room772.obj"); 
            OBJFile object773 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room773.obj");
            OBJFile object774 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room774.obj"); 
            OBJFile object775 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room775.obj");
            OBJFile object776 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room776.obj");
            OBJFile object777 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room777.obj"); 
            OBJFile object778 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room778.obj");
            OBJFile object779 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room779.obj"); 
            OBJFile object780 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room780.obj"); 
            OBJFile object781 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\room781.obj");

            OBJFile object782 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\MapFix.obj");
            OBJFile object783 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\easteregg1.obj");
            OBJFile object784 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\easteregg2.obj");
            OBJFile object785 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\easteregg3.obj");
            OBJFile object786 = new OBJFile(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\Models\easteregg3_1.obj");

            //NewInstancesForOldRift
            AddModel(object1, "MapGeo_Instance_0");
            AddModel2(object2, "MapGeo_Instance_1");
            AddModel3(object3, "MapGeo_Instance_2");
            AddModel4(object4, "MapGeo_Instance_3");
            AddModel5(object5, "MapGeo_Instance_4");
            AddModel6(object6, "MapGeo_Instance_5");
            AddModel7(object7, "MapGeo_Instance_6");
            AddModel8(object8, "MapGeo_Instance_7");
            AddModel9(object9, "MapGeo_Instance_8");
            AddModel10(object10, "MapGeo_Instance_9");
            AddModel11(object11, "MapGeo_Instance_10");
            AddModel12(object12, "MapGeo_Instance_11");
            AddModel13(object13, "MapGeo_Instance_12");
            AddModel14(object14, "MapGeo_Instance_13");
            AddModel15(object15, "MapGeo_Instance_14");
            AddModel16(object16, "MapGeo_Instance_15");
            AddModel17(object17, "MapGeo_Instance_16");
            AddModel18(object18, "MapGeo_Instance_17");
            AddModel19(object19, "MapGeo_Instance_18");
            AddModel20(object20, "MapGeo_Instance_19");
            AddModel21(object21, "MapGeo_Instance_20");
            AddModel22(object22, "MapGeo_Instance_21");
            AddModel23(object23, "MapGeo_Instance_22");
            AddModel24(object24, "MapGeo_Instance_23");
            AddModel25(object25, "MapGeo_Instance_24");
            AddModel26(object26, "MapGeo_Instance_25");
            AddModel27(object27, "MapGeo_Instance_26");
            AddModel28(object28, "MapGeo_Instance_27");
            AddModel29(object29, "MapGeo_Instance_28");
            AddModel30(object30, "MapGeo_Instance_29");
            AddModel31(object31, "MapGeo_Instance_30");
            AddModel32(object32, "MapGeo_Instance_31");
            AddModel33(object33, "MapGeo_Instance_32");
            AddModel34(object34, "MapGeo_Instance_33");
            AddModel35(object35, "MapGeo_Instance_34");
            AddModel36(object36, "MapGeo_Instance_35");
            AddModel37(object37, "MapGeo_Instance_36");
            AddModel38(object38, "MapGeo_Instance_37");
            AddModel39(object39, "MapGeo_Instance_38");
            AddModel40(object40, "MapGeo_Instance_39");
            AddModel41(object41, "MapGeo_Instance_40");
            AddModel42(object42, "MapGeo_Instance_41");
            AddModel43(object43, "MapGeo_Instance_42");
            AddModel44(object44, "MapGeo_Instance_43");
            AddModel45(object45, "MapGeo_Instance_44");
            AddModel46(object46, "MapGeo_Instance_45");
            AddModel47(object47, "MapGeo_Instance_46");
            AddModel48(object48, "MapGeo_Instance_47");
            AddModel49(object49, "MapGeo_Instance_48");
            AddModel50(object50, "MapGeo_Instance_49");
            AddModel51(object51, "MapGeo_Instance_50");
            AddModel52(object52, "MapGeo_Instance_51");
            AddModel53(object53, "MapGeo_Instance_52");
            AddModel54(object54, "MapGeo_Instance_53");
            AddModel55(object55, "MapGeo_Instance_54");
            AddModel56(object56, "MapGeo_Instance_55");
            AddModel57(object57, "MapGeo_Instance_56");
            AddModel58(object58, "MapGeo_Instance_57");
            AddModel59(object59, "MapGeo_Instance_58");
            AddModel60(object60, "MapGeo_Instance_59");
            AddModel61(object61, "MapGeo_Instance_60");
            AddModel62(object62, "MapGeo_Instance_61");
            AddModel63(object63, "MapGeo_Instance_62");
            AddModel64(object64, "MapGeo_Instance_63");
            AddModel65(object65, "MapGeo_Instance_64");
            AddModel66(object66, "MapGeo_Instance_65");
            AddModel67(object67, "MapGeo_Instance_66");
            AddModel68(object68, "MapGeo_Instance_67");
            AddModel69(object69, "MapGeo_Instance_68");
            AddModel70(object70, "MapGeo_Instance_69");
            AddModel71(object71, "MapGeo_Instance_70");
            AddModel72(object72, "MapGeo_Instance_71");
            AddModel73(object73, "MapGeo_Instance_72");
            AddModel74(object74, "MapGeo_Instance_73");
            AddModel75(object75, "MapGeo_Instance_74");
            AddModel76(object76, "MapGeo_Instance_75");
            AddModel77(object77, "MapGeo_Instance_76");
            AddModel78(object78, "MapGeo_Instance_77");
            AddModel79(object79, "MapGeo_Instance_78");
            AddModel80(object80, "MapGeo_Instance_79");
            AddModel81(object81, "MapGeo_Instance_80");
            AddModel82(object82, "MapGeo_Instance_81");
            //AddModel83(object83, "MapGeo_Instance_82");
            AddModel84(object84, "MapGeo_Instance_83");
            AddModel85(object85, "MapGeo_Instance_84");
            AddModel86(object86, "MapGeo_Instance_85");
            AddModel87(object87, "MapGeo_Instance_86");
            AddModel88(object88, "MapGeo_Instance_87");
            AddModel89(object89, "MapGeo_Instance_88");
            AddModel90(object90, "MapGeo_Instance_89");
            AddModel91(object91, "MapGeo_Instance_90");
            AddModel92(object92, "MapGeo_Instance_91");
            AddModel93(object93, "MapGeo_Instance_92");
            AddModel94(object94, "MapGeo_Instance_93");
            AddModel95(object95, "MapGeo_Instance_94");
            AddModel96(object96, "MapGeo_Instance_95");
            AddModel97(object97, "MapGeo_Instance_96");
            AddModel98(object98, "MapGeo_Instance_97");
            AddModel99(object99, "MapGeo_Instance_98");
            AddModel100(object100, "MapGeo_Instance_99");
            AddModel101(object101, "MapGeo_Instance_100");
            AddModel102(object102, "MapGeo_Instance_101");
            AddModel103(object103, "MapGeo_Instance_102");
            AddModel104(object104, "MapGeo_Instance_103");
            AddModel105(object105, "MapGeo_Instance_104");
            AddModel106(object106, "MapGeo_Instance_105");
            AddModel107(object107, "MapGeo_Instance_106");
            AddModel108(object108, "MapGeo_Instance_107");
            AddModel109(object109, "MapGeo_Instance_108");
            AddModel110(object110, "MapGeo_Instance_109");
            AddModel111(object111, "MapGeo_Instance_110");
            AddModel112(object112, "MapGeo_Instance_111");
            AddModel113(object113, "MapGeo_Instance_112");
            AddModel114(object114, "MapGeo_Instance_113");
            AddModel115(object115, "MapGeo_Instance_114");
            AddModel116(object116, "MapGeo_Instance_115");
            AddModel117(object117, "MapGeo_Instance_116");
            AddModel118(object118, "MapGeo_Instance_117");
            AddModel119(object119, "MapGeo_Instance_118");
            AddModel120(object120, "MapGeo_Instance_119");
            AddModel121(object121, "MapGeo_Instance_120");
            AddModel122(object122, "MapGeo_Instance_121");
            AddModel123(object123, "MapGeo_Instance_122");
            AddModel124(object124, "MapGeo_Instance_123");
            AddModel125(object125, "MapGeo_Instance_124");
            AddModel126(object126, "MapGeo_Instance_125");
            AddModel127(object127, "MapGeo_Instance_126");
            AddModel128(object128, "MapGeo_Instance_127");
            AddModel129(object129, "MapGeo_Instance_128");
            AddModel130(object130, "MapGeo_Instance_129");
            AddModel131(object131, "MapGeo_Instance_130");
            AddModel132(object132, "MapGeo_Instance_131");
            AddModel133(object133, "MapGeo_Instance_132");
            AddModel134(object134, "MapGeo_Instance_133");
            AddModel135(object135, "MapGeo_Instance_134");
            AddModel136(object136, "MapGeo_Instance_135");
            AddModel137(object137, "MapGeo_Instance_136");
            AddModel138(object138, "MapGeo_Instance_137");
            AddModel139(object139, "MapGeo_Instance_138");
            AddModel140(object140, "MapGeo_Instance_139");
            AddModel141(object141, "MapGeo_Instance_140");
            AddModel142(object142, "MapGeo_Instance_141");
            AddModel143(object143, "MapGeo_Instance_142");
            AddModel144(object144, "MapGeo_Instance_143");
            AddModel145(object145, "MapGeo_Instance_144");
            AddModel146(object146, "MapGeo_Instance_145");
            AddModel147(object147, "MapGeo_Instance_146");
            AddModel148(object148, "MapGeo_Instance_147");
            AddModel149(object149, "MapGeo_Instance_148");
            AddModel150(object150, "MapGeo_Instance_149");
            AddModel151(object151, "MapGeo_Instance_150");
            AddModel152(object152, "MapGeo_Instance_151");
            AddModel153(object153, "MapGeo_Instance_152");
            AddModel154(object154, "MapGeo_Instance_153");
            AddModel155(object155, "MapGeo_Instance_154");
            AddModel156(object156, "MapGeo_Instance_155");
            AddModel157(object157, "MapGeo_Instance_156");

            AddModel158(object158, "MapGeo_Instance_158");
            AddModel159(object159, "MapGeo_Instance_159");
            AddModel160(object160, "MapGeo_Instance_160");
            AddModel161(object161, "MapGeo_Instance_161");
            AddModel162(object162, "MapGeo_Instance_162");
            AddModel163(object163, "MapGeo_Instance_163");
            AddModel164(object164, "MapGeo_Instance_164");
            AddModel165(object165, "MapGeo_Instance_165");
            AddModel166(object166, "MapGeo_Instance_166");
            AddModel167(object167, "MapGeo_Instance_167");
            AddModel168(object168, "MapGeo_Instance_168");
            AddModel169(object169, "MapGeo_Instance_169");
            AddModel170(object170, "MapGeo_Instance_170");
            AddModel171(object171, "MapGeo_Instance_171");
            AddModel172(object172, "MapGeo_Instance_172");
            AddModel173(object173, "MapGeo_Instance_173");
            AddModel174(object174, "MapGeo_Instance_174");
            AddModel175(object175, "MapGeo_Instance_175");
            AddModel176(object176, "MapGeo_Instance_176");
            AddModel177(object177, "MapGeo_Instance_177");
            AddModel178(object178, "MapGeo_Instance_178");
            AddModel179(object179, "MapGeo_Instance_179");
            AddModel180(object180, "MapGeo_Instance_180");
            AddModel181(object181, "MapGeo_Instance_181");
            AddModel182(object182, "MapGeo_Instance_182");
            AddModel183(object183, "MapGeo_Instance_183");
            AddModel184(object184, "MapGeo_Instance_184");
            AddModel185(object185, "MapGeo_Instance_185");
            AddModel186(object186, "MapGeo_Instance_186");
            AddModel187(object187, "MapGeo_Instance_187");
            AddModel188(object188, "MapGeo_Instance_188");
            AddModel189(object189, "MapGeo_Instance_189");
            AddModel190(object190, "MapGeo_Instance_190");
            AddModel191(object191, "MapGeo_Instance_191");
            AddModel192(object192, "MapGeo_Instance_192");
            AddModel193(object193, "MapGeo_Instance_193");
            AddModel194(object194, "MapGeo_Instance_194");
            AddModel195(object195, "MapGeo_Instance_195");
            AddModel196(object196, "MapGeo_Instance_196");
            AddModel197(object197, "MapGeo_Instance_197");
            AddModel198(object198, "MapGeo_Instance_198");
            AddModel199(object199, "MapGeo_Instance_199");
            AddModel200(object200, "MapGeo_Instance_200");
            AddModel201(object201, "MapGeo_Instance_201");
            AddModel202(object202, "MapGeo_Instance_202");
            AddModel203(object203, "MapGeo_Instance_203");
            AddModel204(object204, "MapGeo_Instance_204");
            AddModel205(object205, "MapGeo_Instance_205");
            AddModel206(object206, "MapGeo_Instance_206");
            AddModel207(object207, "MapGeo_Instance_207");
            AddModel208(object208, "MapGeo_Instance_208");
            AddModel209(object209, "MapGeo_Instance_209");
            AddModel210(object210, "MapGeo_Instance_210");
            AddModel211(object211, "MapGeo_Instance_211");
            AddModel212(object212, "MapGeo_Instance_212");
            AddModel213(object213, "MapGeo_Instance_213");
            AddModel214(object214, "MapGeo_Instance_214");
            AddModel215(object215, "MapGeo_Instance_215");
            AddModel216(object216, "MapGeo_Instance_216");
            AddModel217(object217, "MapGeo_Instance_217");
            AddModel218(object218, "MapGeo_Instance_218");
            AddModel219(object219, "MapGeo_Instance_219");
            AddModel220(object220, "MapGeo_Instance_220");
            AddModel221(object221, "MapGeo_Instance_221");
            AddModel222(object222, "MapGeo_Instance_222");
            AddModel223(object223, "MapGeo_Instance_223");
            AddModel224(object224, "MapGeo_Instance_224");
            AddModel225(object225, "MapGeo_Instance_225");
            AddModel226(object226, "MapGeo_Instance_226");
            AddModel227(object227, "MapGeo_Instance_227");
            AddModel228(object228, "MapGeo_Instance_228");
            AddModel229(object229, "MapGeo_Instance_229");
            AddModel230(object230, "MapGeo_Instance_230");
            AddModel231(object231, "MapGeo_Instance_231");
            AddModel232(object232, "MapGeo_Instance_232");
            AddModel233(object233, "MapGeo_Instance_233");
            AddModel234(object234, "MapGeo_Instance_234");
            AddModel235(object235, "MapGeo_Instance_235");
            AddModel236(object236, "MapGeo_Instance_236");
            AddModel237(object237, "MapGeo_Instance_237");
            AddModel238(object238, "MapGeo_Instance_238");
            AddModel239(object239, "MapGeo_Instance_239");
            AddModel240(object240, "MapGeo_Instance_240");
            AddModel241(object241, "MapGeo_Instance_241");
            AddModel242(object242, "MapGeo_Instance_242");
            AddModel243(object243, "MapGeo_Instance_243");
            AddModel244(object244, "MapGeo_Instance_244");
            AddModel245(object245, "MapGeo_Instance_245");
            AddModel246(object246, "MapGeo_Instance_246");
            AddModel247(object247, "MapGeo_Instance_247");
            AddModel248(object248, "MapGeo_Instance_248");
            AddModel249(object249, "MapGeo_Instance_249");
            AddModel250(object250, "MapGeo_Instance_250");
            AddModel251(object251, "MapGeo_Instance_251");
            AddModel252(object252, "MapGeo_Instance_252");
            AddModel253(object253, "MapGeo_Instance_253");
            AddModel254(object254, "MapGeo_Instance_254");
            AddModel255(object255, "MapGeo_Instance_255");
            AddModel256(object256, "MapGeo_Instance_256");
            AddModel257(object257, "MapGeo_Instance_257");
            AddModel258(object258, "MapGeo_Instance_258");
            AddModel259(object259, "MapGeo_Instance_259");
            AddModel260(object260, "MapGeo_Instance_260");
            AddModel261(object261, "MapGeo_Instance_261");
            AddModel262(object262, "MapGeo_Instance_262");
            AddModel263(object263, "MapGeo_Instance_263");
            AddModel264(object264, "MapGeo_Instance_264");
            AddModel265(object265, "MapGeo_Instance_265");
            AddModel266(object266, "MapGeo_Instance_266");
            AddModel267(object267, "MapGeo_Instance_267");
            AddModel268(object268, "MapGeo_Instance_268");
            AddModel269(object269, "MapGeo_Instance_269");
            AddModel270(object270, "MapGeo_Instance_270");
            AddModel271(object271, "MapGeo_Instance_271");
            AddModel272(object272, "MapGeo_Instance_272");
            AddModel273(object273, "MapGeo_Instance_273");
            AddModel274(object274, "MapGeo_Instance_274");
            AddModel275(object275, "MapGeo_Instance_275");
            AddModel276(object276, "MapGeo_Instance_276");
            AddModel277(object277, "MapGeo_Instance_277");
            AddModel278(object278, "MapGeo_Instance_278");
            AddModel279(object279, "MapGeo_Instance_279");
            AddModel280(object280, "MapGeo_Instance_280");
            AddModel281(object281, "MapGeo_Instance_281");
            AddModel282(object282, "MapGeo_Instance_282");
            AddModel283(object283, "MapGeo_Instance_283");
            AddModel284(object284, "MapGeo_Instance_284");
            AddModel285(object285, "MapGeo_Instance_285");
            AddModel286(object286, "MapGeo_Instance_286");
            AddModel287(object287, "MapGeo_Instance_287");
            AddModel288(object288, "MapGeo_Instance_288");
            AddModel289(object289, "MapGeo_Instance_289");
            AddModel290(object290, "MapGeo_Instance_290");
            AddModel291(object291, "MapGeo_Instance_291");
            AddModel292(object292, "MapGeo_Instance_292");
            AddModel293(object293, "MapGeo_Instance_293");
            AddModel294(object294, "MapGeo_Instance_294");
            AddModel295(object295, "MapGeo_Instance_295");
            AddModel296(object296, "MapGeo_Instance_296");
            AddModel297(object297, "MapGeo_Instance_297");
            AddModel298(object298, "MapGeo_Instance_298");
            AddModel299(object299, "MapGeo_Instance_299");
            AddModel300(object300, "MapGeo_Instance_300");
            AddModel301(object301, "MapGeo_Instance_301");
            AddModel302(object302, "MapGeo_Instance_302");
            AddModel303(object303, "MapGeo_Instance_303");
            AddModel304(object304, "MapGeo_Instance_304");
            AddModel305(object305, "MapGeo_Instance_305");
            AddModel306(object306, "MapGeo_Instance_306");
            AddModel307(object307, "MapGeo_Instance_307");
            AddModel308(object308, "MapGeo_Instance_308");
            AddModel309(object309, "MapGeo_Instance_309");
            AddModel310(object310, "MapGeo_Instance_310");
            AddModel311(object311, "MapGeo_Instance_311");
            AddModel312(object312, "MapGeo_Instance_312");
            AddModel313(object313, "MapGeo_Instance_313");

            AddModel314(object314, "MapGeo_Instance_314");
            AddModel315(object315, "MapGeo_Instance_315");
            AddModel316(object316, "MapGeo_Instance_316");
            AddModel317(object317, "MapGeo_Instance_317");
            AddModel318(object318, "MapGeo_Instance_318");
            AddModel319(object319, "MapGeo_Instance_319");
            AddModel320(object320, "MapGeo_Instance_320");
            AddModel321(object321, "MapGeo_Instance_321");
            AddModel322(object322, "MapGeo_Instance_322");
            AddModel323(object323, "MapGeo_Instance_323");
            AddModel324(object324, "MapGeo_Instance_324");
            AddModel325(object325, "MapGeo_Instance_325");
            AddModel326(object326, "MapGeo_Instance_326");
            AddModel327(object327, "MapGeo_Instance_327");
            AddModel328(object328, "MapGeo_Instance_328");
            AddModel329(object329, "MapGeo_Instance_329");
            AddModel330(object330, "MapGeo_Instance_330");
            AddModel331(object331, "MapGeo_Instance_331");
            AddModel332(object332, "MapGeo_Instance_332");
            AddModel333(object333, "MapGeo_Instance_333");
            AddModel334(object334, "MapGeo_Instance_334");
            AddModel335(object335, "MapGeo_Instance_335");
            AddModel336(object336, "MapGeo_Instance_336");
            AddModel337(object337, "MapGeo_Instance_337");
            AddModel338(object338, "MapGeo_Instance_338");
            AddModel339(object339, "MapGeo_Instance_339");
            AddModel340(object340, "MapGeo_Instance_340");
            AddModel341(object341, "MapGeo_Instance_341");
            AddModel342(object342, "MapGeo_Instance_342");
            AddModel343(object343, "MapGeo_Instance_343");
            AddModel344(object344, "MapGeo_Instance_344");
            AddModel345(object345, "MapGeo_Instance_345");
            AddModel346(object346, "MapGeo_Instance_346");
            AddModel347(object347, "MapGeo_Instance_347");
            AddModel348(object348, "MapGeo_Instance_348");
            AddModel349(object349, "MapGeo_Instance_349");
            AddModel350(object350, "MapGeo_Instance_350");
            AddModel351(object351, "MapGeo_Instance_351");
            AddModel352(object352, "MapGeo_Instance_352");
            AddModel353(object353, "MapGeo_Instance_353");
            AddModel354(object354, "MapGeo_Instance_354");
            AddModel355(object355, "MapGeo_Instance_355");
            AddModel356(object356, "MapGeo_Instance_356");
            AddModel357(object357, "MapGeo_Instance_357");
            AddModel358(object358, "MapGeo_Instance_358");
            AddModel359(object359, "MapGeo_Instance_359");
            AddModel360(object360, "MapGeo_Instance_360");
            AddModel361(object361, "MapGeo_Instance_361");
            AddModel362(object362, "MapGeo_Instance_362");
            AddModel363(object363, "MapGeo_Instance_363");
            AddModel364(object364, "MapGeo_Instance_364");
            AddModel365(object365, "MapGeo_Instance_365");
            AddModel366(object366, "MapGeo_Instance_366");
            AddModel367(object367, "MapGeo_Instance_367");
            AddModel368(object368, "MapGeo_Instance_368");
            AddModel369(object369, "MapGeo_Instance_369");
            AddModel370(object370, "MapGeo_Instance_370");
            AddModel371(object371, "MapGeo_Instance_371");
            AddModel372(object372, "MapGeo_Instance_372");
            AddModel373(object373, "MapGeo_Instance_373");
            AddModel374(object374, "MapGeo_Instance_374");
            AddModel375(object375, "MapGeo_Instance_375");
            AddModel376(object376, "MapGeo_Instance_376");
            AddModel377(object377, "MapGeo_Instance_377");
            AddModel378(object378, "MapGeo_Instance_378");
            AddModel379(object379, "MapGeo_Instance_379");
            AddModel380(object380, "MapGeo_Instance_380");
            AddModel381(object381, "MapGeo_Instance_381");
            AddModel382(object382, "MapGeo_Instance_382");
            AddModel383(object383, "MapGeo_Instance_383");
            AddModel384(object384, "MapGeo_Instance_384");
            AddModel385(object385, "MapGeo_Instance_385");
            AddModel386(object386, "MapGeo_Instance_386");
            AddModel387(object387, "MapGeo_Instance_387");
            AddModel388(object388, "MapGeo_Instance_388");
            AddModel389(object389, "MapGeo_Instance_389");
            AddModel390(object390, "MapGeo_Instance_390");
            AddModel391(object391, "MapGeo_Instance_391");
            AddModel392(object392, "MapGeo_Instance_392");
            AddModel393(object393, "MapGeo_Instance_393");
            AddModel394(object394, "MapGeo_Instance_394");
            AddModel395(object395, "MapGeo_Instance_395");
            AddModel396(object396, "MapGeo_Instance_396");
            AddModel397(object397, "MapGeo_Instance_397");
            AddModel398(object398, "MapGeo_Instance_398");
            AddModel399(object399, "MapGeo_Instance_399");
            AddModel400(object400, "MapGeo_Instance_400");
            AddModel401(object401, "MapGeo_Instance_401");
            AddModel402(object402, "MapGeo_Instance_402");
            AddModel403(object403, "MapGeo_Instance_403");
            AddModel404(object404, "MapGeo_Instance_404");
            AddModel405(object405, "MapGeo_Instance_405");
            AddModel406(object406, "MapGeo_Instance_406");
            AddModel407(object407, "MapGeo_Instance_407");
            AddModel408(object408, "MapGeo_Instance_408");
            AddModel409(object409, "MapGeo_Instance_409");
            AddModel410(object410, "MapGeo_Instance_410");
            AddModel411(object411, "MapGeo_Instance_411");
            AddModel412(object412, "MapGeo_Instance_412");
            AddModel413(object413, "MapGeo_Instance_413");
            AddModel414(object414, "MapGeo_Instance_414");
            AddModel415(object415, "MapGeo_Instance_415");
            AddModel416(object416, "MapGeo_Instance_416");
            AddModel417(object417, "MapGeo_Instance_417");
            AddModel418(object418, "MapGeo_Instance_418");
            AddModel419(object419, "MapGeo_Instance_419");
            AddModel420(object420, "MapGeo_Instance_420");
            AddModel421(object421, "MapGeo_Instance_421");
            AddModel422(object422, "MapGeo_Instance_422");
            AddModel423(object423, "MapGeo_Instance_423");
            AddModel424(object424, "MapGeo_Instance_424");
            AddModel425(object425, "MapGeo_Instance_425");
            AddModel426(object426, "MapGeo_Instance_426");
            AddModel427(object427, "MapGeo_Instance_427");
            AddModel428(object428, "MapGeo_Instance_428");
            AddModel429(object429, "MapGeo_Instance_429");
            AddModel430(object430, "MapGeo_Instance_430");
            AddModel431(object431, "MapGeo_Instance_431");
            AddModel432(object432, "MapGeo_Instance_432");
            AddModel433(object433, "MapGeo_Instance_433");
            AddModel434(object434, "MapGeo_Instance_434");
            AddModel435(object435, "MapGeo_Instance_435");
            AddModel436(object436, "MapGeo_Instance_436");
            AddModel437(object437, "MapGeo_Instance_437");
            AddModel438(object438, "MapGeo_Instance_438");
            AddModel439(object439, "MapGeo_Instance_439");
            AddModel440(object440, "MapGeo_Instance_440");
            AddModel441(object441, "MapGeo_Instance_441");
            AddModel442(object442, "MapGeo_Instance_442");
            AddModel443(object443, "MapGeo_Instance_443");
            AddModel444(object444, "MapGeo_Instance_444");
            AddModel445(object445, "MapGeo_Instance_445");
            AddModel446(object446, "MapGeo_Instance_446");
            AddModel447(object447, "MapGeo_Instance_447");
            AddModel448(object448, "MapGeo_Instance_448");
            AddModel449(object449, "MapGeo_Instance_449");
            AddModel450(object450, "MapGeo_Instance_450");
            AddModel451(object451, "MapGeo_Instance_451");
            AddModel452(object452, "MapGeo_Instance_452");
            AddModel453(object453, "MapGeo_Instance_453");
            AddModel454(object454, "MapGeo_Instance_454");
            AddModel455(object455, "MapGeo_Instance_455");
            AddModel456(object456, "MapGeo_Instance_456");
            AddModel457(object457, "MapGeo_Instance_457");
            AddModel458(object458, "MapGeo_Instance_458");
            AddModel459(object459, "MapGeo_Instance_459");
            AddModel460(object460, "MapGeo_Instance_460");
            AddModel461(object461, "MapGeo_Instance_461");
            AddModel462(object462, "MapGeo_Instance_462");
            AddModel463(object463, "MapGeo_Instance_463");
            AddModel464(object464, "MapGeo_Instance_464");
            AddModel465(object465, "MapGeo_Instance_465");
            AddModel466(object466, "MapGeo_Instance_466");
            AddModel467(object467, "MapGeo_Instance_467");
            AddModel468(object468, "MapGeo_Instance_468");
            AddModel469(object469, "MapGeo_Instance_469");

            AddModel470(object470, "MapGeo_Instance_470");
            AddModel471(object471, "MapGeo_Instance_471");
            AddModel472(object472, "MapGeo_Instance_472");
            AddModel473(object473, "MapGeo_Instance_473");
            AddModel474(object474, "MapGeo_Instance_474");
            AddModel475(object475, "MapGeo_Instance_475");
            AddModel476(object476, "MapGeo_Instance_476");
            AddModel477(object477, "MapGeo_Instance_477");
            AddModel478(object478, "MapGeo_Instance_478");
            AddModel479(object479, "MapGeo_Instance_479");
            AddModel480(object480, "MapGeo_Instance_480");
            AddModel481(object481, "MapGeo_Instance_481");
            AddModel482(object482, "MapGeo_Instance_482");
            AddModel483(object483, "MapGeo_Instance_483");
            AddModel484(object484, "MapGeo_Instance_484");
            AddModel485(object485, "MapGeo_Instance_485");
            AddModel486(object486, "MapGeo_Instance_486");
            AddModel487(object487, "MapGeo_Instance_487");
            AddModel488(object488, "MapGeo_Instance_488");
            AddModel489(object489, "MapGeo_Instance_489");
            AddModel490(object490, "MapGeo_Instance_490");
            AddModel491(object491, "MapGeo_Instance_491");
            AddModel492(object492, "MapGeo_Instance_492");
            AddModel493(object493, "MapGeo_Instance_493");
            AddModel494(object494, "MapGeo_Instance_494");
            AddModel495(object495, "MapGeo_Instance_495");
            AddModel496(object496, "MapGeo_Instance_496");
            AddModel497(object497, "MapGeo_Instance_497");
            AddModel498(object498, "MapGeo_Instance_498");
            AddModel499(object499, "MapGeo_Instance_499");
            AddModel500(object500, "MapGeo_Instance_500");
            AddModel501(object501, "MapGeo_Instance_501");
            AddModel502(object502, "MapGeo_Instance_502");
            AddModel503(object503, "MapGeo_Instance_503");
            AddModel504(object504, "MapGeo_Instance_504");
            AddModel505(object505, "MapGeo_Instance_505");
            AddModel506(object506, "MapGeo_Instance_506");
            AddModel507(object507, "MapGeo_Instance_507");
            AddModel508(object508, "MapGeo_Instance_508");
            AddModel509(object509, "MapGeo_Instance_509");
            AddModel510(object510, "MapGeo_Instance_510");
            AddModel511(object511, "MapGeo_Instance_511");
            AddModel512(object512, "MapGeo_Instance_512");
            AddModel513(object513, "MapGeo_Instance_513");
            AddModel514(object514, "MapGeo_Instance_514");
            AddModel515(object515, "MapGeo_Instance_515");
            AddModel516(object516, "MapGeo_Instance_516");
            AddModel517(object517, "MapGeo_Instance_517");
            AddModel518(object518, "MapGeo_Instance_518");
            AddModel519(object519, "MapGeo_Instance_519");
            AddModel520(object520, "MapGeo_Instance_520");
            AddModel521(object521, "MapGeo_Instance_521");
            AddModel522(object522, "MapGeo_Instance_522");
            AddModel523(object523, "MapGeo_Instance_523");
            AddModel524(object524, "MapGeo_Instance_524");
            AddModel525(object525, "MapGeo_Instance_525");
            AddModel526(object526, "MapGeo_Instance_526");
            AddModel527(object527, "MapGeo_Instance_527");
            AddModel528(object528, "MapGeo_Instance_528");
            AddModel529(object529, "MapGeo_Instance_529");
            AddModel530(object530, "MapGeo_Instance_530");
            AddModel531(object531, "MapGeo_Instance_531");
            AddModel532(object532, "MapGeo_Instance_532");
            AddModel533(object533, "MapGeo_Instance_533");
            AddModel534(object534, "MapGeo_Instance_534");
            AddModel535(object535, "MapGeo_Instance_535");
            AddModel536(object536, "MapGeo_Instance_536");
            AddModel537(object537, "MapGeo_Instance_537");
            AddModel538(object538, "MapGeo_Instance_538");
            AddModel539(object539, "MapGeo_Instance_539");
            AddModel540(object540, "MapGeo_Instance_540");
            AddModel541(object541, "MapGeo_Instance_541");
            AddModel542(object542, "MapGeo_Instance_542");
            AddModel543(object543, "MapGeo_Instance_543");
            AddModel544(object544, "MapGeo_Instance_544");
            AddModel545(object545, "MapGeo_Instance_545");
            AddModel546(object546, "MapGeo_Instance_546");
            AddModel547(object547, "MapGeo_Instance_547");
            AddModel548(object548, "MapGeo_Instance_548");
            AddModel549(object549, "MapGeo_Instance_549");
            AddModel550(object550, "MapGeo_Instance_550");
            AddModel551(object551, "MapGeo_Instance_551");
            AddModel552(object552, "MapGeo_Instance_552");
            AddModel553(object553, "MapGeo_Instance_553");
            AddModel554(object554, "MapGeo_Instance_554");
            AddModel555(object555, "MapGeo_Instance_555");
            AddModel556(object556, "MapGeo_Instance_556");
            AddModel557(object557, "MapGeo_Instance_557");
            AddModel558(object558, "MapGeo_Instance_558");
            AddModel559(object559, "MapGeo_Instance_559");
            AddModel560(object560, "MapGeo_Instance_560");
            AddModel561(object561, "MapGeo_Instance_561");
            AddModel562(object562, "MapGeo_Instance_562");
            AddModel563(object563, "MapGeo_Instance_563");
            AddModel564(object564, "MapGeo_Instance_564");
            AddModel565(object565, "MapGeo_Instance_565");
            AddModel566(object566, "MapGeo_Instance_566");
            AddModel567(object567, "MapGeo_Instance_567");
            AddModel568(object568, "MapGeo_Instance_568");
            AddModel569(object569, "MapGeo_Instance_569");
            AddModel570(object570, "MapGeo_Instance_570");
            AddModel571(object571, "MapGeo_Instance_571");
            AddModel572(object572, "MapGeo_Instance_572");
            AddModel573(object573, "MapGeo_Instance_573");
            AddModel574(object574, "MapGeo_Instance_574");
            AddModel575(object575, "MapGeo_Instance_575");
            AddModel576(object576, "MapGeo_Instance_576");
            AddModel577(object577, "MapGeo_Instance_577");
            AddModel578(object578, "MapGeo_Instance_578");
            AddModel579(object579, "MapGeo_Instance_579");
            AddModel580(object580, "MapGeo_Instance_580");
            AddModel581(object581, "MapGeo_Instance_581");
            AddModel582(object582, "MapGeo_Instance_582");
            AddModel583(object583, "MapGeo_Instance_583");
            AddModel584(object584, "MapGeo_Instance_584");
            AddModel585(object585, "MapGeo_Instance_585");
            AddModel586(object586, "MapGeo_Instance_586");
            AddModel587(object587, "MapGeo_Instance_587");
            AddModel588(object588, "MapGeo_Instance_588");
            AddModel589(object589, "MapGeo_Instance_589");
            AddModel590(object590, "MapGeo_Instance_590");
            AddModel591(object591, "MapGeo_Instance_591");
            AddModel592(object592, "MapGeo_Instance_592");
            AddModel593(object593, "MapGeo_Instance_593");
            AddModel594(object594, "MapGeo_Instance_594");
            AddModel595(object595, "MapGeo_Instance_595");
            AddModel596(object596, "MapGeo_Instance_596");
            AddModel597(object597, "MapGeo_Instance_597");
            AddModel598(object598, "MapGeo_Instance_598");
            AddModel599(object599, "MapGeo_Instance_599");
            AddModel600(object600, "MapGeo_Instance_600");
            AddModel601(object601, "MapGeo_Instance_601");
            AddModel602(object602, "MapGeo_Instance_602");
            AddModel603(object603, "MapGeo_Instance_603");
            AddModel604(object604, "MapGeo_Instance_604");
            AddModel605(object605, "MapGeo_Instance_605");
            AddModel606(object606, "MapGeo_Instance_606");
            AddModel607(object607, "MapGeo_Instance_607");
            AddModel608(object608, "MapGeo_Instance_608");
            AddModel609(object609, "MapGeo_Instance_609");
            AddModel610(object610, "MapGeo_Instance_610");
            AddModel611(object611, "MapGeo_Instance_611");
            AddModel612(object612, "MapGeo_Instance_612");
            AddModel613(object613, "MapGeo_Instance_613");
            AddModel614(object614, "MapGeo_Instance_614");
            AddModel615(object615, "MapGeo_Instance_615");
            AddModel616(object616, "MapGeo_Instance_616");
            AddModel617(object617, "MapGeo_Instance_617");
            AddModel618(object618, "MapGeo_Instance_618");
            AddModel619(object619, "MapGeo_Instance_619");
            AddModel620(object620, "MapGeo_Instance_620");
            AddModel621(object621, "MapGeo_Instance_621");
            AddModel622(object622, "MapGeo_Instance_622");
            AddModel623(object623, "MapGeo_Instance_623");
            AddModel624(object624, "MapGeo_Instance_624");
            AddModel625(object625, "MapGeo_Instance_625");

            AddModel626(object626, "MapGeo_Instance_626");
            AddModel627(object627, "MapGeo_Instance_627");
            AddModel628(object628, "MapGeo_Instance_628");
            AddModel629(object629, "MapGeo_Instance_629");
            AddModel630(object630, "MapGeo_Instance_630");
            AddModel631(object631, "MapGeo_Instance_631");
            AddModel632(object632, "MapGeo_Instance_632");
            AddModel633(object633, "MapGeo_Instance_633");
            AddModel634(object634, "MapGeo_Instance_634");
            AddModel635(object635, "MapGeo_Instance_635");
            AddModel636(object636, "MapGeo_Instance_636");
            AddModel637(object637, "MapGeo_Instance_637");
            AddModel638(object638, "MapGeo_Instance_638");
            AddModel639(object639, "MapGeo_Instance_639");
            AddModel640(object640, "MapGeo_Instance_640");
            AddModel641(object641, "MapGeo_Instance_641");
            AddModel642(object642, "MapGeo_Instance_642");
            AddModel643(object643, "MapGeo_Instance_643");
            AddModel644(object644, "MapGeo_Instance_644");
            AddModel645(object645, "MapGeo_Instance_645");
            AddModel646(object646, "MapGeo_Instance_646");
            AddModel647(object647, "MapGeo_Instance_647");
            AddModel648(object648, "MapGeo_Instance_648");
            AddModel649(object649, "MapGeo_Instance_649");
            AddModel650(object650, "MapGeo_Instance_650");
            AddModel651(object651, "MapGeo_Instance_651");
            AddModel652(object652, "MapGeo_Instance_652");
            AddModel653(object653, "MapGeo_Instance_653");
            AddModel654(object654, "MapGeo_Instance_654");
            AddModel655(object655, "MapGeo_Instance_655");
            AddModel656(object656, "MapGeo_Instance_656");
            AddModel657(object657, "MapGeo_Instance_657");
            AddModel658(object658, "MapGeo_Instance_658");
            AddModel659(object659, "MapGeo_Instance_659");
            AddModel660(object660, "MapGeo_Instance_660");
            AddModel661(object661, "MapGeo_Instance_661");
            AddModel662(object662, "MapGeo_Instance_662");
            AddModel663(object663, "MapGeo_Instance_663");
            AddModel664(object664, "MapGeo_Instance_664");
            AddModel665(object665, "MapGeo_Instance_665");
            AddModel666(object666, "MapGeo_Instance_666");
            AddModel667(object667, "MapGeo_Instance_667");
            AddModel668(object668, "MapGeo_Instance_668");
            AddModel669(object669, "MapGeo_Instance_669");
            AddModel670(object670, "MapGeo_Instance_670");
            AddModel671(object671, "MapGeo_Instance_671");
            AddModel672(object672, "MapGeo_Instance_672");
            AddModel673(object673, "MapGeo_Instance_673");
            AddModel674(object674, "MapGeo_Instance_674");
            AddModel675(object675, "MapGeo_Instance_675");
            AddModel676(object676, "MapGeo_Instance_676");
            AddModel677(object677, "MapGeo_Instance_677");
            AddModel678(object678, "MapGeo_Instance_678");
            AddModel679(object679, "MapGeo_Instance_679");
            AddModel680(object680, "MapGeo_Instance_680");
            AddModel681(object681, "MapGeo_Instance_681");
            AddModel682(object682, "MapGeo_Instance_682");
            AddModel683(object683, "MapGeo_Instance_683");
            AddModel684(object684, "MapGeo_Instance_684");
            AddModel685(object685, "MapGeo_Instance_685");
            AddModel686(object686, "MapGeo_Instance_686");
            AddModel687(object687, "MapGeo_Instance_687");
            AddModel688(object688, "MapGeo_Instance_688");
            AddModel689(object689, "MapGeo_Instance_689");
            AddModel690(object690, "MapGeo_Instance_690");
            AddModel691(object691, "MapGeo_Instance_691");
            AddModel692(object692, "MapGeo_Instance_692");
            AddModel693(object693, "MapGeo_Instance_693");
            AddModel694(object694, "MapGeo_Instance_694");
            AddModel695(object695, "MapGeo_Instance_695");
            AddModel696(object696, "MapGeo_Instance_696");
            AddModel697(object697, "MapGeo_Instance_697");
            AddModel698(object698, "MapGeo_Instance_698");
            AddModel699(object699, "MapGeo_Instance_699");
            AddModel700(object700, "MapGeo_Instance_700");
            AddModel701(object701, "MapGeo_Instance_701");
            AddModel702(object702, "MapGeo_Instance_702");
            AddModel703(object703, "MapGeo_Instance_703");
            AddModel704(object704, "MapGeo_Instance_704");
            AddModel705(object705, "MapGeo_Instance_705");
            AddModel706(object706, "MapGeo_Instance_706");
            AddModel707(object707, "MapGeo_Instance_707");
            AddModel708(object708, "MapGeo_Instance_708");
            AddModel709(object709, "MapGeo_Instance_709");
            AddModel710(object710, "MapGeo_Instance_710");
            AddModel711(object711, "MapGeo_Instance_711");
            AddModel712(object712, "MapGeo_Instance_712");
            AddModel713(object713, "MapGeo_Instance_713");
            AddModel714(object714, "MapGeo_Instance_714");
            AddModel715(object715, "MapGeo_Instance_715");
            AddModel716(object716, "MapGeo_Instance_716");
            AddModel717(object717, "MapGeo_Instance_717");
            AddModel718(object718, "MapGeo_Instance_718");
            AddModel719(object719, "MapGeo_Instance_719");
            AddModel720(object720, "MapGeo_Instance_720");
            AddModel721(object721, "MapGeo_Instance_721");
            AddModel722(object722, "MapGeo_Instance_722");
            AddModel723(object723, "MapGeo_Instance_723");
            AddModel724(object724, "MapGeo_Instance_724");
            AddModel725(object725, "MapGeo_Instance_725");
            AddModel726(object726, "MapGeo_Instance_726");
            AddModel727(object727, "MapGeo_Instance_727");
            AddModel728(object728, "MapGeo_Instance_728");
            AddModel729(object729, "MapGeo_Instance_729");
            AddModel730(object730, "MapGeo_Instance_730");
            AddModel731(object731, "MapGeo_Instance_731");
            AddModel732(object732, "MapGeo_Instance_732");
            AddModel733(object733, "MapGeo_Instance_733");
            AddModel734(object734, "MapGeo_Instance_734");
            AddModel735(object735, "MapGeo_Instance_735");
            AddModel736(object736, "MapGeo_Instance_736");
            AddModel737(object737, "MapGeo_Instance_737");
            AddModel738(object738, "MapGeo_Instance_738");
            AddModel739(object739, "MapGeo_Instance_739");
            AddModel740(object740, "MapGeo_Instance_740");
            AddModel741(object741, "MapGeo_Instance_741");
            AddModel742(object742, "MapGeo_Instance_742");
            AddModel743(object743, "MapGeo_Instance_743");
            AddModel744(object744, "MapGeo_Instance_744");
            AddModel745(object745, "MapGeo_Instance_745");
            AddModel746(object746, "MapGeo_Instance_746");
            AddModel747(object747, "MapGeo_Instance_747");
            AddModel748(object748, "MapGeo_Instance_748");
            AddModel749(object749, "MapGeo_Instance_749");
            AddModel750(object750, "MapGeo_Instance_750");
            AddModel751(object751, "MapGeo_Instance_751");
            AddModel752(object752, "MapGeo_Instance_752");
            AddModel753(object753, "MapGeo_Instance_753");
            AddModel754(object754, "MapGeo_Instance_754");
            AddModel755(object755, "MapGeo_Instance_755");
            AddModel756(object756, "MapGeo_Instance_756");
            AddModel757(object757, "MapGeo_Instance_757");
            AddModel758(object758, "MapGeo_Instance_758");
            AddModel759(object759, "MapGeo_Instance_759");
            AddModel760(object760, "MapGeo_Instance_760");
            AddModel761(object761, "MapGeo_Instance_761");
            AddModel762(object762, "MapGeo_Instance_762");
            AddModel763(object763, "MapGeo_Instance_763");
            AddModel764(object764, "MapGeo_Instance_764");
            AddModel765(object765, "MapGeo_Instance_765");
            AddModel766(object766, "MapGeo_Instance_766");
            AddModel767(object767, "MapGeo_Instance_767");
            AddModel768(object768, "MapGeo_Instance_768");
            AddModel769(object769, "MapGeo_Instance_769");
            AddModel770(object770, "MapGeo_Instance_770");
            AddModel771(object771, "MapGeo_Instance_771");
            AddModel772(object772, "MapGeo_Instance_772");
            AddModel773(object773, "MapGeo_Instance_773");
            AddModel774(object774, "MapGeo_Instance_774");
            AddModel775(object775, "MapGeo_Instance_775");
            AddModel776(object776, "MapGeo_Instance_776");
            AddModel777(object777, "MapGeo_Instance_777");
            AddModel778(object778, "MapGeo_Instance_778");
            AddModel779(object779, "MapGeo_Instance_779");
            AddModel780(object780, "MapGeo_Instance_780");
            AddModel781(object781, "MapGeo_Instance_781");

            AddModel782(object782, "MapGeo_Instance_782");
            AddModel783(object783, "MapGeo_Instance_783");
            AddModel784(object784, "MapGeo_Instance_784");
            AddModel785(object785, "MapGeo_Instance_785");
            AddModel786(object786, "MapGeo_Instance_786");


            //Write the new Mapgeo File. Current Version is 11
            mgeo.Write(@"K:\Riot Games\LeagueSkins\OldHalloweenRift\HWRift\data\maps\mapgeometry\sr\base_srx.mapgeo", 11);

            //All Layers

            void AddModel782(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.AllLayers);
                mgeo.AddModel(object3);
            } //Fix for Top- and Botlane
            void AddModel783(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/easteregg1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.AllLayers);
                mgeo.AddModel(object3);
            } //Easter Egg PSST :)
            void AddModel784(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/easteregg2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.AllLayers);
                mgeo.AddModel(object3);
            } //Easter Egg PSST :)
            void AddModel785(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/easteregg3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.AllLayers);
                mgeo.AddModel(object3);
            } //Easter Egg PSST :)
            void AddModel786(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/easteregg3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.AllLayers);
                mgeo.AddModel(object3);
            } //Easter Egg PSST :)

            //Layer 1 (Base Layer)
            void AddModel(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel2(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel3(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel4(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel5(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel6(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel7(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel8(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel9(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel10(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel11(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                
                mgeo.AddModel(object3);
            }
            void AddModel12(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel13(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel14(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel15(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel16(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel17(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel18(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel19(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel20(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel21(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel22(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel23(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel24(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel25(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel26(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel27(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel28(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel29(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel30(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel31(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel32(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel33(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel34(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel35(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel36(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel37(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel38(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel39(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel40(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel41(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel42(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel43(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel44(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel45(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel46(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel47(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel48(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel49(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel50(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel51(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel52(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel53(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel54(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel55(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel56(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel57(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel58(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel59(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel60(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel61(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel62(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel63(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel64(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel65(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel66(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel67(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel68(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel69(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel70(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel71(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel72(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel73(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel74(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel75(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel76(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel77(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel78(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel79(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel80(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel81(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel82(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel83(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room83", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel84(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel85(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel86(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }

            
            void AddModel87(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room87", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel88(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room88", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel89(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room89", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel90(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room90", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel91(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room91", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel92(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room92", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel93(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room93", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel94(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room94", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel95(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room95", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel96(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room96", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel97(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room97", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel98(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room98", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel99(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room99", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel100(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room100", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel101(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room101", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel102(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room102", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel103(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room103", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel104(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room104", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel105(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room105", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel106(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room106", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel107(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room107", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel108(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room108", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel109(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room109", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel110(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room110", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel111(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room111", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel112(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room112", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel113(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room113", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel114(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room114", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel115(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room115", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel116(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room116", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel117(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room117", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel118(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room118", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel119(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room119", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel120(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room120", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel121(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room121", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel122(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room122", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel123(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel124(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room124", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel125(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room125", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel126(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room126", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel127(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room127", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel128(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room128", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel129(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room129", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel130(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room130", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel131(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room131", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel132(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room132", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel133(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room133", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel134(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room134", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel135(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room135", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel136(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room136", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel137(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room137", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel138(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room138", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel139(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room139", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel140(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room140", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel141(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room141", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel142(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room142", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel143(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room143", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel144(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room144", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel145(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room145", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel146(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room146", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel147(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room147", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel148(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room148", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel149(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room149", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel150(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room150", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel151(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room151", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel152(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room152", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel153(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room153", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel154(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room154", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel155(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room155", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }
            void AddModel156(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room156", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object3);
            }
            void AddModel157(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room157", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer1);
                mgeo.AddModel(object2);
            }


            
            //Layer 2 = Fire (Infernal)
            void AddModel158(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel159(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel160(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel161(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel162(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel163(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel164(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel165(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel166(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel167(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel168(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                
                mgeo.AddModel(object3);
            }
            void AddModel169(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel170(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel171(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel172(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel173(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel174(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel175(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel176(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel177(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel178(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel179(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel180(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel181(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel182(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel183(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel184(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel185(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel186(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel187(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel188(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel189(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel190(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel191(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel192(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel193(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel194(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel195(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel196(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel197(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel198(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel199(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel200(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel201(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel202(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel203(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel204(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel205(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel206(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel207(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel208(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel209(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel210(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel211(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel212(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel213(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel214(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel215(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel216(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel217(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel218(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel219(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel220(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel221(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel222(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel223(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel224(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel225(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel226(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel227(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel228(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel229(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel230(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel231(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel232(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel233(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel234(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel235(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel236(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel237(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel238(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel239(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel240(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel241(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel242(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel243(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room87", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel244(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room88", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel245(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room89", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel246(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room90", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel247(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room91", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel248(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room92", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel249(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room93", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel250(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room94", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel251(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room95", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel252(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room96", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel253(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room97", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel254(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room98", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel255(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room99", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel256(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room100", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel257(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room101", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel258(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room102", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel259(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room103", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel260(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room104", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel261(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room105", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel262(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room106", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel263(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room107", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel264(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room108", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel265(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room109", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel266(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room110", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel267(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room111", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel268(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room112", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel269(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room113", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel270(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room114", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel271(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room115", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel272(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room116", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel273(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room117", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel274(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room118", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel275(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room119", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel276(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room120", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel277(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room121", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel278(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room122", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel279(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel280(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room124", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel281(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room125", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel282(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room126", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel283(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room127", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel284(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room128", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel285(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room129", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel286(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room130", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel287(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room131", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel288(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room132", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel289(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room133", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel290(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room134", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel291(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room135", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel292(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room136", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel293(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room137", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel294(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room138", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel295(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room139", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel296(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room140", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel297(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room141", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel298(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room142", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel299(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room143", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel300(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room144", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel301(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room145", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel302(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room146", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel303(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room147", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel304(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room148", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel305(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room149", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel306(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room150", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel307(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room151", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel308(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room152", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel309(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room153", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel310(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room154", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel311(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room155", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            void AddModel312(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room156", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object3);
            }
            void AddModel313(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room157", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer2);
                mgeo.AddModel(object2);
            }
            //Layer 3 = Earth (Mountain)
            void AddModel314(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel315(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel316(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel317(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel318(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel319(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel320(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel321(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel322(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel323(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel324(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                
                mgeo.AddModel(object3);
            }
            void AddModel325(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel326(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel327(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel328(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel329(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel330(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel331(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel332(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel333(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel334(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel335(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel336(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel337(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel338(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel339(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel340(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel341(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel342(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel343(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel344(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel345(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel346(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel347(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel348(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel349(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel350(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel351(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel352(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel353(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel354(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel355(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel356(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel357(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel358(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel359(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel360(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel361(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel362(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel363(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel364(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel365(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel366(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel367(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel368(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel369(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel370(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel371(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel372(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel373(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel374(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel375(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel376(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel377(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel378(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel379(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel380(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel381(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel382(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel383(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel384(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel385(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel386(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel387(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel388(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel389(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel390(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel391(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel392(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel393(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel394(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel395(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel396(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel397(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel398(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel399(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room87", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel400(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room88", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel401(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room89", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel402(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room90", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel403(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room91", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel404(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room92", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel405(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room93", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel406(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room94", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel407(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room95", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel408(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room96", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel409(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room97", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel410(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room98", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel411(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room99", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel412(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room100", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel413(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room101", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel414(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room102", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel415(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room103", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel416(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room104", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel417(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room105", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel418(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room106", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel419(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room107", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel420(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room108", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel421(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room109", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel422(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room110", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel423(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room111", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel424(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room112", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel425(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room113", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel426(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room114", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel427(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room115", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel428(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room116", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel429(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room117", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel430(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room118", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel431(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room119", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel432(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room120", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel433(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room121", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel434(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room122", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel435(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel436(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room124", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel437(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room125", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel438(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room126", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel439(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room127", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel440(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room128", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel441(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room129", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel442(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room130", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel443(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room131", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel444(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room132", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel445(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room133", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel446(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room134", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel447(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room135", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel448(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room136", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel449(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room137", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel450(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room138", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel451(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room139", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel452(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room140", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel453(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room141", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel454(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room142", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel455(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room143", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel456(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room144", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel457(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room145", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel458(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room146", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel459(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room147", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel460(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room148", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel461(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room149", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel462(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room150", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel463(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room151", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel464(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room152", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel465(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room153", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel466(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room154", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel467(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room155", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            void AddModel468(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room156", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object3);
            }
            void AddModel469(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room157", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer3);
                mgeo.AddModel(object2);
            }
            //Layer 4 = Water (Ocean)
            void AddModel470(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel471(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel472(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel473(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel474(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel475(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel476(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel477(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel478(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel479(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel480(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                
                mgeo.AddModel(object3);
            }
            void AddModel481(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel482(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel483(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel484(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel485(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel486(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel487(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel488(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel489(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel490(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel491(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel492(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel493(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel494(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel495(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel496(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel497(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel498(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel499(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel500(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel501(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel502(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel503(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel504(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel505(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel506(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel507(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel508(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel509(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel510(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel511(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel512(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel513(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel514(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel515(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel516(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel517(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel518(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel519(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel520(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel521(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel522(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel523(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel524(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel525(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel526(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel527(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel528(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel529(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel530(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel531(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel532(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel533(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel534(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel535(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel536(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel537(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel538(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel539(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel540(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel541(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel542(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel543(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel544(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel545(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel546(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel547(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel548(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel549(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel550(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel551(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel552(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel553(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel554(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel555(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room87", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel556(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room88", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel557(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room89", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel558(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room90", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel559(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room91", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel560(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room92", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel561(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room93", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel562(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room94", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel563(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room95", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel564(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room96", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel565(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room97", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel566(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room98", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel567(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room99", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel568(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room100", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel569(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room101", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel570(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room102", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel571(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room103", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel572(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room104", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel573(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room105", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel574(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room106", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel575(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room107", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel576(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room108", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel577(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room109", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel578(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room110", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel579(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room111", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel580(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room112", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel581(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room113", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel582(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room114", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel583(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room115", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel584(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room116", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel585(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room117", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel586(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room118", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel587(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room119", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel588(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room120", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel589(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room121", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel590(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room122", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel591(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel592(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room124", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel593(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room125", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel594(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room126", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel595(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room127", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel596(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room128", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel597(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room129", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel598(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room130", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel599(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room131", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel600(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room132", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel601(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room133", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel602(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room134", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel603(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room135", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel604(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room136", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel605(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room137", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel606(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room138", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel607(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room139", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel608(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room140", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel609(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room141", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel610(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room142", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel611(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room143", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel612(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room144", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel613(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room145", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel614(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room146", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel615(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room147", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel616(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room148", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel617(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room149", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel618(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room150", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel619(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room151", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel620(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room152", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel621(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room153", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel622(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room154", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel623(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room155", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            void AddModel624(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room156", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object3);
            }
            void AddModel625(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room157", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer4);
                mgeo.AddModel(object2);
            }
            //Layer 5 = Wind (Cloud)
            void AddModel626(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room1", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel627(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room2", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel628(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room3", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel629(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room4", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel630(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room5", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel631(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room6", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel632(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room7", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel633(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room8", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel634(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room9", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel635(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room10", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel636(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room11", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                
                mgeo.AddModel(object3);
            }
            void AddModel637(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room12", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel638(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room13", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel639(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room14", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel640(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room15", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel641(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room16", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel642(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room17", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel643(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room18", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel644(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room19", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel645(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room20", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel646(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room21", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel647(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room22", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel648(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel649(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room24", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel650(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room25", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel651(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room26", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel652(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room27", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel653(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room28", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel654(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room29", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel655(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room30", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel656(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room31", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel657(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room32", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel658(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room33", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel659(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room34", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel660(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room35", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel661(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room36", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel662(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room37", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel663(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room38", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel664(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room39", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel665(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room40", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel666(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room41", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel667(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room42", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel668(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room43", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel669(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room44", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel670(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room45", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel671(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room46", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel672(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room47", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel673(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room48", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel674(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room49", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel675(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room50", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel676(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room51", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel677(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room52", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel678(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room53", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel679(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room54", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel680(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room55", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel681(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room56", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel682(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room57", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel683(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room58", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel684(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room59", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel685(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room60", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel686(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room61", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel687(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room62", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel688(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room63", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel689(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room64", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel690(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room65", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel691(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room66", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel692(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room67", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel693(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room68", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel694(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room69", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel695(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room70", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel696(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room71", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel697(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room72", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel698(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room73", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel699(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room74", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel700(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room75", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel701(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room76", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel702(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room77", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel703(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room78", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel704(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room79", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel705(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room80", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel706(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room81", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel707(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room82", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel708(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room84", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel709(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room85", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel710(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room86", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel711(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room87", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked1.tga"; //testing tga files instead of dds
               // BakedTexture = (1);
                mgeo.AddModel(object3);
            }
            void AddModel712(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room88", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked2.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel713(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room89", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked3.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel714(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room90", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked4.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel715(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room91", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked5.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel716(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room92", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked6.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel717(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room93", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked7.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel718(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room94", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked8.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel719(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room95", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked9.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel720(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room96", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked10.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel721(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room97", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked11.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel722(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room98", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked12.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel723(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room99", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked13.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel724(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room100", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked14.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel725(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room101", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked15.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel726(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room102", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked16.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel727(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room103", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked17.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel728(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room104", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked18.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel729(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room105", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked19.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel730(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room106", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked20.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel731(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room107", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked21.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel732(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room108", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked22.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel733(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room109", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked23.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel734(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room110", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked24.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel735(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room111", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked25.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel736(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room112", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked26.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel737(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room113", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked27.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel738(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room114", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked28.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel739(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room115", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked29.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel740(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room116", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked30.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel741(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room117", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked31.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel742(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room118", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked32.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel743(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room119", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked33.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel744(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room120", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked34.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel745(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room121", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked35.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel746(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room122", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                //object3.BakedPaintTexture = "Maps/Kitpieces/Baked/Baked36.tga"; //testing tga files instead of dds
                mgeo.AddModel(object3);
            }
            void AddModel747(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room23", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel748(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room124", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel749(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room125", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel750(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room126", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel751(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room127", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel752(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room128", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel753(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room129", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel754(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room130", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel755(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room131", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel756(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room132", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel757(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room133", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel758(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room134", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel759(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room135", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel760(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room136", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel761(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room137", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel762(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room138", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel763(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room139", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel764(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room140", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel765(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room141", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel766(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room142", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel767(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room143", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel768(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room144", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel769(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room145", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel770(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room146", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel771(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room147", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel772(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room148", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel773(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room149", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel774(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room150", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel775(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room151", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel776(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room152", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel777(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room153", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel778(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room154", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel779(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room155", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }
            void AddModel780(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room156", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object3 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object3);
            }
            void AddModel781(OBJFile obj, string name)
            {
                (List<ushort> indices, List<MapGeometryVertex> vertices) = obj.GetMGEOData();
                MapGeometrySubmesh submesh = new MapGeometrySubmesh("Maps/KitPieces/Summoners_Rift/Materials/room157", 0, (uint)indices.Count, 0, (uint)vertices.Count);
                MapGeometryModel object2 = new MapGeometryModel(name, vertices, indices, new List<MapGeometrySubmesh>() { submesh }, MapGeometryLayer.Layer5);
                mgeo.AddModel(object2);
            }

        }

        static void BinEdit()
        {
            //BinTreeProperty test = new BinTreeProperty (@"K:\Riot Games\LeagueSkins\OldSummonersRiftRemastered2\Map11\data\maps\mapgeometry\sr\base_srx.materials.bin");
           // test.Write(@"K:\Riot Games\LeagueSkins\OldSummonersRiftRemastered2\Map11\data\maps\mapgeometry\sr\base_srx.materials_new.bin");
        }

    }
}
