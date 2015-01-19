Shader "Custom/SampleShader01"
{
	Properties
	{
		_HogeTex ( "Base", 2D ) = "white" {}
	}

    SubShader
    {
		CGPROGRAM

		#pragma surface surf Lambert

		sampler _HogeTex;

		struct Input
		{
			float2 uv_HogeTex;
			float4 vtxColor : COLOR;
		};

		void surf( Input IN, inout SurfaceOutput o )
		{
			o.Albedo = tex2D( _HogeTex, IN.uv_HogeTex ).rgb;
        }

		ENDCG
    }
}