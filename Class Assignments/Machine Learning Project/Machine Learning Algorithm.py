#Plotting Cross-Validated Predictions Algorithm

from sklearn import datasets
from sklearn.model_selection import cross_val_predict
from sklearn import linear_model
import matplotlib.pyplot as plt
import pandas as pd

X = pd.read_csv('/2021-2022 School Year 1st Semester/Machine Learning and Robotics/Machine Learning Project/Electric_Vehicle_Population_Data.csv'
                      ,usecols = [10], nrows = 100)
y = pd.read_csv('/2021-2022 School Year 1st Semester/Machine Learning and Robotics/Machine Learning Project/Electric_Vehicle_Population_Data.csv'
                      ,usecols = [11], nrows =100)

lr = linear_model.LinearRegression()

# cross_val_predict returns an array of the same size as `y` where each entry
# is a prediction obtained by cross validation:
predicted = cross_val_predict(lr, X, y, cv=10)

fig, ax = plt.subplots()
ax.scatter(y, predicted, edgecolors=(0, 0, 0))
ax.plot([y.min(), y.max()], [y.min(), y.max()], "k--", lw=4)
ax.set_xlabel("Measured")
ax.set_ylabel("Predicted")
plt.show()
