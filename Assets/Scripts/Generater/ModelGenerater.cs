﻿using UnityEngine;
using System.IO;
using System.Collections;
using System.CodeDom;
using System.CodeDom.Compiler;

public class ModelGenerater
{
	/*
	public static string GenerateDataModel(CodeCompileUnit compileunit)
	{
		CSharpCodeProvider provider = new CSharpCodeProvider();// Generate the code with the C# code provider.
		
		// Build the output file name.
		string sourceFile;
		if (provider.FileExtension[0] == '.')
		{
			sourceFile = "HelloWorld" + provider.FileExtension;
		}
		else
		{
			sourceFile = "HelloWorld." + provider.FileExtension;
		}
		
		// Create a TextWriter to a StreamWriter to the output file.
		using (StreamWriter sw = new StreamWriter(sourceFile, false))
		{
			IndentedTextWriter tw = new IndentedTextWriter(sw, "    ");
			// Generate source code using the code provider.
			provider.GenerateCodeFromCompileUnit(compileunit, tw, new CodeGeneratorOptions());
			// Close the output file.
			tw.Close();
		}
		
		return sourceFile;
	}
	*/
}
