﻿public class ShaderProperties
{

    //List of all the built in shaders as of Unity 4.2
    public static string[] NAMES = new[]{   "Hidden/Camera-DepthNormalTexture",
                                            "Hidden/Camera-DepthTexture",
                                            "GUI/Text Shader",
                                            "Hidden/BlitCopy",
                                            "Hidden/InternalClear",
                                            "Hidden/Internal-CombineDepthNormals",
                                            "Hidden/Internal-Flare",
                                            "Hidden/Internal-GUITexture",
                                            "Hidden/Internal-GUITextureBlit",
                                            "Hidden/Internal-GUITextureClip",
                                            "Hidden/Internal-GUITextureClipText",
                                            "Hidden/Internal-Halo",
                                            "Hidden/Internal-PrePassCollectShadows",
                                            "Hidden/Internal-PrePassLighting",
                                            "Hidden/Shadow-ScreenBlur",
                                            "Hidden/Shadow-ScreenBlurRotated",
                                            "Transparent/Bumped Diffuse",
                                            "Transparent/Bumped Specular",
                                            "Transparent/Diffuse",
                                            "Transparent/Specular",
                                            "Transparent/Parallax Diffuse",
                                            "Transparent/Parallax Specular",
                                            "Transparent/VertexLit",
                                            "Transparent/Cutout/Bumped Diffuse",
                                            "Transparent/Cutout/Bumped Specular",
                                            "Transparent/Cutout/Diffuse",
                                            "Transparent/Cutout/Specular",
                                            "Transparent/Cutout/Soft Edge Unlit",
                                            "Transparent/Cutout/VertexLit",
                                            "Decal",
                                            "FX/Flare",
                                            "Self-Illumin/Bumped Diffuse",
                                            "Self-Illumin/Bumped Specular",
                                            "Self-Illumin/Diffuse",
                                            "Self-Illumin/Specular",
                                            "Self-Illumin/Parallax Diffuse",
                                            "Self-Illumin/Parallax Specular",
                                            "Self-Illumin/VertexLit",
                                            "Legacy Shaders/Lightmapped/Bumped Diffuse",
                                            "Legacy Shaders/Lightmapped/Bumped Specular",
                                            "Legacy Shaders/Lightmapped/Diffuse",
                                            "Legacy Shaders/Lightmapped/Specular",
                                            "Legacy Shaders/Lightmapped/VertexLit",
                                            "Bumped Diffuse",
                                            "Bumped Specular",
                                            "Diffuse",
                                            "Diffuse Detail",
                                            "Legacy Shaders/Diffuse Fast",
                                            "Specular",
                                            "Parallax Diffuse",
                                            "Parallax Specular",
                                            "VertexLit",
                                            "Particles/Additive",
                                            "Particles/~Additive-Multiply",
                                            "Particles/Additive (Soft)",
                                            "Particles/Alpha Blended",
                                            "Particles/Blend",
                                            "Particles/Multiply",
                                            "Particles/Multiply (Double)",
                                            "Particles/Alpha Blended Premultiply",
                                            "Particles/VertexLit Blended",
                                            "Reflective/Bumped Diffuse",
                                            "Reflective/Bumped Unlit",
                                            "Reflective/Bumped Specular",
                                            "Reflective/Bumped VertexLit",
                                            "Reflective/Diffuse",
                                            "Reflective/Specular",
                                            "Reflective/Parallax Diffuse",
                                            "Reflective/Parallax Specular",
                                            "Reflective/VertexLit",
                                            "RenderFX/Skybox Cubed",
                                            "RenderFX/Skybox",
                                            "Mobile/Bumped Diffuse",
                                            "Mobile/Bumped Specular (1 Directional Light)",
                                            "Mobile/Bumped Specular",
                                            "Mobile/Diffuse",
                                            "Mobile/Unlit (Supports Lightmap)",
                                            "Mobile/Particles/Additive",
                                            "Mobile/Particles/VertexLit Blended",
                                            "Mobile/Particles/Alpha Blended",
                                            "Mobile/Particles/Multiply",
                                            "Mobile/Skybox",
                                            "Mobile/VertexLit (Only Directional Lights)",
                                            "Mobile/VertexLit",
                                            "Nature/Tree Soft Occlusion Bark",
                                            "Hidden/Nature/Tree Soft Occlusion Bark Rendertex",
                                            "Nature/Tree Soft Occlusion Leaves",
                                            "Hidden/Nature/Tree Soft Occlusion Leaves Rendertex",
                                            "Hidden/Nature/Terrain/Bumped Specular AddPass",
                                            "Nature/Terrain/Bumped Specular",
                                            "Nature/Tree Creator Bark",
                                            "Hidden/Nature/Tree Creator Bark Optimized",
                                            "Hidden/Nature/Tree Creator Bark Rendertex",
                                            "Nature/Tree Creator Leaves",
                                            "Nature/Tree Creator Leaves Fast",
                                            "Hidden/Nature/Tree Creator Leaves Fast Optimized",
                                            "Hidden/Nature/Tree Creator Leaves Optimized",
                                            "Hidden/Nature/Tree Creator Leaves Rendertex",
                                            "Sprites/Alpha Blended",
                                            "Sprites/Pixel Snap/Alpha Blended",
                                            "Hidden/TerrainEngine/Details/Vertexlit",
                                            "Hidden/TerrainEngine/Details/WavingDoublePass",
                                            "Hidden/TerrainEngine/Details/BillboardWavingDoublePass",
                                            "Hidden/TerrainEngine/Splatmap/Lightmap-AddPass",
                                            "Nature/Terrain/Diffuse",
                                            "Hidden/TerrainEngine/BillboardTree",
                                            "Unlit/Transparent",
                                            "Unlit/Transparent Cutout",
                                            "Unlit/Texture"};

    //List of all the built in shader properties as of unity 4.2
    public static string[] PROPERTIES = new[]{    "_BackTex", 
                                                  "_BumpMap", 
                                                  "_BumpSpecMap", 
                                                  "_Control", 
                                                  "_DecalTex",
                                                  "_Detail",
                                                  "_DownTex", 
                                                  "_FrontTex",
                                                  "_GlossMap", 
                                                  "_Illum", 
                                                  "_LeftTex",
                                                  "_LightMap", 
                                                  "_LightTextureB0", 
                                                  "_MainTex", 
                                                  "_ParallaxMap", 
                                                  "_RightTex",
                                                  "_ShadowOffset", 
                                                  "_Splat0",
                                                  "_Splat1", "_Splat2", 
                                                  "_Splat3",
                                                  "_TranslucencyMap", 
                                                  "_UpTex", 
                                                  "_Tex", 
                                                  "_Cube" };
}