﻿using Ninject;
using RailwayStation.Core;

namespace RailwayStation.Model
{
    public class ModelDIContainer : AbstractDIContainer
    {
        private ModelDIContainer()
        {
            kernel = new StandardKernel(new ModelModule());
        }

        public static AbstractDIContainer Instance
        {
            get
            {
                lock (lockObj)
                {
                    instance ??= new ModelDIContainer();
                    return instance;
                }
            }
        }
    }
}
